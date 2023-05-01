using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;
using System.Diagnostics;
using System.Collections.Generic;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Diga.WebView2.Wrapper.EventArguments;

namespace Gateway
{
    public partial class GameBrowse : Form
    {
        bool isMax = false;
        string idmPath;
       

        public GameBrowse()
        {
            InitializeComponent();
            this.KeyPreview = true; // enable key events for the form
            BrowserWb.FrameNavigationCompleted += BrowserWb_FrameNavigationCompleted;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameBrowse_PreviewKeyDown);
            LoadData();

        }

        private void BrowserWb_FrameNavigationCompleted(object sender, NavigationCompletedEventArgs e)
        {
            BrowserWb.DownloadStarting += (_, downloadArgs) =>
            {
                downloadArgs.Cancel = 1;

                // send the download request to IDM
                string downloadUrl = downloadArgs.ResultFilePath;
                string arguments = $"/d \"{downloadUrl}\"";
                Process.Start(idmPath, arguments);
            };

            BrowserWb.NewWindowRequested += (_, args) =>
            {
                args.Handled = 1;
                BrowserWb.Navigate(args.uri);
            };
        }


        private void ADDgame_Click(object sender, EventArgs e)
        {
            BrowserWb.Navigate("https://repack-games.com/");
        }

        private void CustomURL_Click(object sender, EventArgs e)
        {
            string CusUrl = Microsoft.VisualBasic.Interaction.InputBox("Enter the URL:", "Custom URL", "https://www.example.com");
            if (Uri.IsWellFormedUriString(CusUrl, UriKind.Absolute))
            {
                if (BrowserWb != null)
                {
                    BrowserWb.Navigate(CusUrl);
                }

            }
            else
            {
                MessageBox.Show("Invalid URL.");
            }
        }


        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaxmizeBtn_Click(object sender, EventArgs e)
        {
            if (isMax == false)
            {
                this.WindowState = FormWindowState.Maximized;
                isMax = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMax = false;
            }
        }

        private void DownloadHubbtn_Click(object sender, EventArgs e)
        {
            // Open IDM
            if (!string.IsNullOrEmpty(idmPath) && File.Exists(idmPath))
            {
                Process.Start(idmPath);
            }
            else
            {
                MessageBox.Show("IDM is not installed on your machine.");
            }
        }



        private void GameBrowse_Load(object sender, EventArgs e)
        {
            LoadData();
            // Check if IDM is installed
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\DownloadManager"))
                {
                    if (key != null)
                    {
                        object path = key.GetValue("ExePath");
                        if (path != null)
                        {
                            idmPath = path.ToString();
                        }
                    }
                }


                if (string.IsNullOrEmpty(idmPath) || !File.Exists(idmPath))
                {
                    MessageBox.Show("IDM is not installed on your machine.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while checking for IDM installation: " + ex.Message);
            }
        }

       




        private void HidePanelbtn_Click(object sender, EventArgs e)
        {
            Shortpanel.Visible = false;
        }

        private void GameBrowse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                Shortpanel.Visible = !Shortpanel.Visible;
            }
        }

        private void BrowserWb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                // Toggle the visibility of the panel here
                if (Shortpanel.Visible == false)
                {
                    Shortpanel.Visible = true;
                }
                else
                {
                    Shortpanel.Visible = false;
                }
            }
        }
        private void GameBrowse_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                if (Shortpanel.Visible)
                {
                    Shortpanel.Hide();
                }
                else
                {
                    Shortpanel.Show();
                }
                e.IsInputKey = true; // prevent the control with focus from processing the key event
            }
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }



        public void AddButton(CustomSitesDatabase customSite)
        {
            Guna2Button gameButton = new Guna2Button();
            gameButton.Size = new Size(85, 38);
            gameButton.Text = customSite.Site_Name;
            gameButton.TextAlign = HorizontalAlignment.Center;
            gameButton.Font = new Font("Gilroy ExtraBold", 10);
            gameButton.FillColor = Color.Transparent;
            gameButton.Tag = customSite;
            gameButton.Click += GameButton_Click;
            gameButton.MouseDown += GameButton_MouseDown;
            gameButton.MouseUp += GameButton_MouseUp;
            Shortpanel.Controls.Add(gameButton);
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            var customSite = (CustomSitesDatabase)button.Tag;
            if (Uri.TryCreate(customSite.Site_Url, UriKind.Absolute, out Uri uri))
            {
                BrowserWb.Navigate(uri.ToString());
            }
        }


        private void GameButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var button = (Guna2Button)sender;
                var customSite = (CustomSitesDatabase)button.Tag;

                // Show input boxes to prompt the user for site name and URL
                string siteUrl = Microsoft.VisualBasic.Interaction.InputBox("Enter the site URL:", "Edit Custom Site", customSite.Site_Url);
                string siteName = Microsoft.VisualBasic.Interaction.InputBox("Enter the site name:", "Edit Custom Site", customSite.Site_Name);

                // Update the custom site object and button text
                customSite.Site_Name = siteName;
                customSite.Site_Url = siteUrl;
                button.Text = siteName;
            }
        }

        private void GameButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                var button = (Guna2Button)sender;
                var customSite = (CustomSitesDatabase)button.Tag;
                customSitesList.Remove(customSite);
                Shortpanel.Controls.Remove(button);
            }
        }

        private List<CustomSitesDatabase> customSitesList = new List<CustomSitesDatabase>();

        private void PlusShort_Click(object sender, EventArgs e)
        {
            string url = Microsoft.VisualBasic.Interaction.InputBox("Enter the URL:", "Custom URL", "https://www.example.com");
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter the Name:", "Custom Name", "PizzaSite....");

            CustomSitesDatabase customSite = new CustomSitesDatabase();
            customSite.Site_Url = url;
            customSite.Site_Name = name;
            customSitesList.Add(customSite);

            AddButton(customSite);
        }



        private void SaveData()
        {
            try
            {
                using (FileStream fs = new FileStream("CustomSites.bin", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, customSitesList);
                    Console.WriteLine("Data saved successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while saving data: " + ex.Message);
            }
        }


        private void LoadData()
        {
            try
            {
                using (FileStream fs = new FileStream("CustomSites.bin", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    customSitesList = (List<CustomSitesDatabase>)formatter.Deserialize(fs);
                    Console.WriteLine("Data loaded successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while loading data: " + ex.Message);
            }
        }





        private void GameBrowse_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void WebBckButton_Click(object sender, EventArgs e)
        {
            //if (BrowserWb.CanGoBack)
           // {
          // //     BrowserWb.GoBack();
           // }
        }


    }
}
