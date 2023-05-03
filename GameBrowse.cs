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
using System.Threading.Tasks;
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
           // BrowserWb.FrameNavigationCompleted += BrowserWb_FrameNavigationCompleted;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameBrowse_PreviewKeyDown);
            LoadData();
            // Attach the CoreWebView2Ready event handler
            BrowserWb.CoreWebView2InitializationCompleted += OnCoreWebView2Ready;
        }

        private async void OnCoreWebView2Ready(object sender, EventArgs e)
        {
            // create a CoreWebView2EnvironmentOptions object
            CoreWebView2EnvironmentOptions options = new CoreWebView2EnvironmentOptions();

            // set the UserAgent property to a custom value
            options.AdditionalBrowserArguments = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.77 Safari/537.36 MyCustomApp/1.0 (mydomain.com)";

            // create a CoreWebView2Environment object with the options
            CoreWebView2Environment env = await CoreWebView2Environment.CreateAsync(null, null, options);

            // Get the CoreWebView2 instance and set the environment
            var coreWebView2 = BrowserWb.CoreWebView2;
            //await coreWebView2.Environment.(env);

        }


        private void BrowserWb_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            BrowserWb.CoreWebView2.DownloadStarting += (_, downloadArgs) =>
            {
                downloadArgs.Cancel = true;

                // send the download request to IDM
                Uri downloadUri = new Uri(downloadArgs.DownloadOperation.Uri);
                string downloadUrl = downloadUri.AbsoluteUri;
                Process.Start(idmPath, $"/d \"{downloadUrl}\" /p");
            };

            BrowserWb.CoreWebView2.NewWindowRequested += (_, args) =>
            {
                args.Handled = true;
                BrowserWb.CoreWebView2.Navigate(args.Uri);
            };
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
        public void AddButton(CustomSitesDatabase customSite)
        {
            Guna2Button gameButton = new Guna2Button();
            gameButton.Size = new Size(85, 38);
            gameButton.Text = customSite.Site_Name;
            gameButton.TextAlign = HorizontalAlignment.Center;
            gameButton.Font = new Font("Gilroy ExtraBold", 8);
            gameButton.FillColor = Color.Transparent;
            gameButton.Tag = customSite;

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
                BrowserWb.CoreWebView2.Navigate(uri.ToString());
            }

            // handle button click event
            SaveData();
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

            // handle button click event
            SaveData();
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

            if (e.Button == MouseButtons.Left)
            {
                var button = (Guna2Button)sender;
                var customSite = (CustomSitesDatabase)button.Tag;
                if (Uri.TryCreate(customSite.Site_Url, UriKind.Absolute, out Uri uri))
                {
                    BrowserWb.CoreWebView2.Navigate(uri.ToString());
                }

                // handle button click event
                SaveData();
            }

                // handle button click event
                SaveData();


            // handle button click event
            SaveData();

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
            List<CustomSiteData> customSites = new List<CustomSiteData>();

            foreach (Control control in Shortpanel.Controls)
            {
                if (control is Guna2Button button && button.Tag is CustomSitesDatabase customSite)
                {
                    customSites.Add(new CustomSiteData
                    {
                        SiteName = customSite.Site_Name,
                        SiteUrl = customSite.Site_Url
                    });
                }
            }

            // serialize the customSites list to an XML file
            XmlSerializer serializer = new XmlSerializer(typeof(List<CustomSiteData>));
            using (StreamWriter writer = new StreamWriter("CustomSites.xml"))
            {
                serializer.Serialize(writer, customSites);
            }
        }
        private void LoadData()
        {
            // deserialize the customSites list from the XML file
            List<CustomSiteData> customSites;
            XmlSerializer serializer = new XmlSerializer(typeof(List<CustomSiteData>));
            try
            {
                using (StreamReader reader = new StreamReader("CustomSites.xml"))
                {
                    customSites = (List<CustomSiteData>)serializer.Deserialize(reader);
                }
            }
            catch
            {
                // if the XML file does not exist or is invalid, create an empty list
                customSites = new List<CustomSiteData>();
            }

            // create a button for each custom site
            foreach (CustomSiteData customSiteData in customSites)
            {
                CustomSitesDatabase customSite = new CustomSitesDatabase
                {
                    Site_Name = customSiteData.SiteName,
                    Site_Url = customSiteData.SiteUrl
                };
                AddButton(customSite);
            }
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
[Serializable]
public class CustomSiteData
{
    public string SiteName { get; set; }
    public string SiteUrl { get; set; }
}
