using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;
using Guna.UI2.WinForms;
using System.Drawing;
using Newtonsoft.Json;
using System.Linq;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace Gateway
{
    public partial class Gateway : Form
    {
        private bool isDragging = false;
        private Point lastLocation;
        private Stopwatch gameTimer = new Stopwatch();
        private ContextMenuStrip contextMenu = new ContextMenuStrip();
        // GAMES DATA
        private const string GAMES_FILE_PATH = "games.json";
        private List<GameData> gamesData = new List<GameData>();
        //APPS DATA
        private const string APPS_FILE_PATH = "apps.json";
        private List<AppData> appdData = new List<AppData>();
        public Gateway()
        {
            InitializeComponent();
            LoadGames();
            LoadApps();
        }

        private void LoadGames()
        {
            if (File.Exists(GAMES_FILE_PATH))
            {
                string gamesJson = File.ReadAllText(GAMES_FILE_PATH);
                JArray gamesArray = JArray.Parse(gamesJson);

                foreach (var gameToken in gamesArray)
                {
                    GameData gameData = gameToken.ToObject<GameData>();
                    AddGameButton(gameData);
                    gamesData.Add(gameData);
                }
            }
        }
        
        private void LoadApps()
        {
            if (File.Exists(APPS_FILE_PATH))
            {
                string appsJson = File.ReadAllText(APPS_FILE_PATH);
                JArray appsArray = JArray.Parse(appsJson);

                foreach (var appToken in appsArray)
                {
                    AppData appsData = appToken.ToObject<AppData>();
                    AddAppButton(appsData);
                    appdData.Add(appsData);
                }
            }
        }
        
        private void Gateway_Load(object sender, EventArgs e)
        {
            
        }

        public static string GetGameFolderSize(string gameFolder)
        {
            long size = 0;

            try
            {
                DirectoryInfo di = new DirectoryInfo(gameFolder);

                // Get the size of all files in the directory and subdirectories
                foreach (FileInfo fi in di.EnumerateFiles("*", SearchOption.AllDirectories))
                {
                    size += fi.Length;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Unknown";
            }

            // Convert the size to a readable format (e.g. "1.23 GB")
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (size >= 1024 && order < sizes.Length - 1)
            {
                size /= 1024;
                order++;
            }

            return String.Format("{0:0.##} {1}", size, sizes[order]);
        }


        private void ADDgame_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Executable Files|*.exe";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Extract game information
                    string gameName = Path.GetFileNameWithoutExtension(dlg.FileName);
                    string gameImgPath = Path.Combine(Path.GetDirectoryName(dlg.FileName), gameName + ".png");

                    // Save game image
                    Icon gameIcon = Icon.ExtractAssociatedIcon(dlg.FileName);
                    using (FileStream fs = new FileStream(gameImgPath, FileMode.Create))
                    {
                        gameIcon.ToBitmap().Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    // Generate a unique ID for the game
                    string gameId = Guid.NewGuid().ToString();

                    // Save the game data along with the ID
                    GameData gameData = new GameData
                    {
                        GameId = gameId,
                        GameFolder = dlg.FileName,
                        ImgPath = gameImgPath,
                        Name = gameName
                    };

                    gamesData.Add(gameData);
                    AddGameButton(gameData);

                    // Save games data to JSON file
                    string gamesJson = JsonConvert.SerializeObject(gamesData);
                    File.WriteAllText(GAMES_FILE_PATH, gamesJson);

                    // write to INI file
                    string iniFilePath = "games.ini";
                    string sectionName = gameId;
                    string keyName = "location";
                    string value = dlg.FileName;
                    WritePrivateProfileString(sectionName, keyName, value, iniFilePath);
                }
            }

        }
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        private void AddGameButton(GameData gameData)
        {
            // Check if the GameSize property is empty
            if (string.IsNullOrEmpty(gameData.GameSize))
            {
                // Calculate the game size and update the GameSize property
                string gameFolder = Path.GetDirectoryName(gameData.GameFolder);
                string gameSize = GetGameFolderSize(gameFolder);
                gameData.GameSize = gameSize;

                // Show a message box with the game size
                MessageBox.Show($"The game size is {gameSize}");
            }

            Guna2Button gameButton = new Guna2Button();
            gameButton.Image = Icon.ExtractAssociatedIcon(gameData.GameFolder).ToBitmap();
            gameButton.Tag = gameData;
            gameButton.Size = new Size(70, 70);
            gameButton.FillColor = Color.Transparent;
            gameButton.Click += GameButton_Click;
            gameButton.MouseDown += GameButton_MouseUp; // new event handler for MouseDown
            GamesFlow.Controls.Add(gameButton);
        }

        private void AddAppButton(AppData appData)
        {
            Guna2Button appButton = new Guna2Button();
            appButton.Image = Icon.ExtractAssociatedIcon(appData.AppFolder).ToBitmap();
            appButton.BackgroundImageLayout = ImageLayout.Stretch;

            appButton.Tag = appData;
            appButton.Size = new Size(70, 70);
            appButton.FillColor = Color.Transparent;
            appButton.Click += appButton_Click;
            appButton.MouseDown += appButton_MouseUp; // new event handler for MouseDown
            AppsFlow.Controls.Add(appButton);
        }


        private void appButton_MouseUp(object sender, MouseEventArgs e)
        {
            // Check if the middle mouse button is clicked
            if (e.Button == MouseButtons.Middle)
            {

                // Remove the button from the FlowLayoutPanel
                Guna2Button appBtn = (Guna2Button)sender;
                AppsFlow.Controls.Remove(appBtn);
                appBtn.Dispose(); // Optional: dispose the removed control

                // Remove the game data from the list
                AppData appData = (AppData)appBtn.Tag;
                appdData.Remove(appData);

                // Save games data to JSON file
                string appJson = JsonConvert.SerializeObject(appdData);
                File.WriteAllText(APPS_FILE_PATH, appJson);
            }
        }
        
        private void appButton_Click(object sender, EventArgs e)
        {
            AppData appData = (AppData)((Guna2Button)sender).Tag;

            // Start a new process to launch the game
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = appData.AppFolder;
            startInfo.WorkingDirectory = Path.GetDirectoryName(appData.AppFolder);
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }
        
        private void GameButton_Click(object sender, EventArgs e)
        {
            
        }
        private void GameButton_MouseUp(object sender, MouseEventArgs e)
        {
        
            // Check if the middle mouse button is clicked
            if (e.Button == MouseButtons.Middle)
            {

                // Remove the button from the FlowLayoutPanel
                Guna2Button gameBtn = (Guna2Button)sender;
                GamesFlow.Controls.Remove(gameBtn);
                gameBtn.Dispose(); // Optional: dispose the removed control

                // Remove the game data from the list
                GameData gameData = (GameData)gameBtn.Tag;
                gamesData.Remove(gameData);

                // Save games data to JSON file
                string gamesJson = JsonConvert.SerializeObject(gamesData);
                File.WriteAllText(GAMES_FILE_PATH, gamesJson);
            }
            if (e.Button == MouseButtons.Right)
            {
                Guna2Button gameButton = (Guna2Button)sender;
                GameData gameData = (GameData)gameButton.Tag;

                // Start the game timer
                gameTimer.Start();

                // Launch the game and add event handler for Process.Exited event
                Process process = new Process();
                process.StartInfo.FileName = gameData.GameFolder;
                process.EnableRaisingEvents = true;
                process.Exited += Process_Exited;
                process.Start();
            }
            if (e.Button == MouseButtons.Left)
            {
                GameData gameData = (GameData)((Guna2Button)sender).Tag;
                GameCard GC = new GameCard(gameData);
                GC.ShowDialog();

            }
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            // Get the game data for the exited process
            Process process = (Process)sender;
            GameData gameData = gamesData.FirstOrDefault(g => g.GameFolder == process.StartInfo.FileName);

            if (gameData != null)
            {
                // Stop the game timer
                gameTimer.Stop();

                // Update the game time
                gameData.GameTime += gameTimer.Elapsed;

                // Save games data to JSON file
                string gamesJson = JsonConvert.SerializeObject(gamesData);
                File.WriteAllText(GAMES_FILE_PATH, gamesJson);
            }
        }

        private void ADDapp_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Executable Files|*.exe";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Extract game information
                    string appName = Path.GetFileNameWithoutExtension(dlg.FileName);
                    string appImgPath = Path.Combine(Path.GetDirectoryName(dlg.FileName), appName + ".png");

                    // Save game image
                    Icon appIcon = Icon.ExtractAssociatedIcon(dlg.FileName);
                    using (FileStream fs = new FileStream(appImgPath, FileMode.Create))
                    {
                        appIcon.ToBitmap().Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    // Generate a unique ID for the game
                    string appId = Guid.NewGuid().ToString();

                    // Save the game data along with the ID
                    AppData appData = new AppData
                    {
                        AppId = appId,
                        AppFolder = dlg.FileName,
                        ImgPath = appImgPath,
                        Name = appName
                    };

                    appdData.Add(appData);
                    AddAppButton(appData);

                    // Save games data to JSON file
                    string appsJson = JsonConvert.SerializeObject(appdData);
                    File.WriteAllText(APPS_FILE_PATH, appsJson);

                    // write to INI file
                    string iniFilePath = "apps.ini";
                    string sectionName = appId;
                    string keyName = "location";
                    string value = dlg.FileName;
                    WritePrivateProfileString(sectionName, keyName, value, iniFilePath);
                }
            }
            
        }

        private void GameBrowse_Click(object sender, EventArgs e)
        {
            GameBrowse gb = new GameBrowse();
            gb.Show(); // Show the new form
        }
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DragBTN_Click(object sender, EventArgs e)
        {
        }
        private void Mainpanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }
        private void Mainpanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void Mainpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Gateway_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the game play time profile to a binary file
           // gameProfile.SaveToFile();
        }
        private void gamepadBTN_Click(object sender, EventArgs e)
        {
            //GameCard GC = new GameCard();
            //GC.Show(); // Show the new form
        }
        private void AboutBTN_Click(object sender, EventArgs e)
        {
            ABOUTFORM af = new ABOUTFORM();
            af.Show(); // Show the new form
        }

        private void grad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void ConsoleBTN_Click(object sender, EventArgs e)
        {
            ConsolForm cf = new ConsolForm();
            cf.Show(); // Show the new form

            this.Visible = false;
        }

        private void GamepadButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    // read the controller path from the settings
                    string controllerpath = Properties.Settings.Default.ControllerPath;

                    // if the controllerpath is null, prompt user to select the controller app executable file
                    if (string.IsNullOrEmpty(controllerpath))
                    {
                        // create a new instance of the OpenFileDialog class
                        OpenFileDialog openFileDialog = new OpenFileDialog();

                        // set the file filter to only show executable files
                        openFileDialog.Filter = "Executable Files|*.exe";

                        // display the OpenFileDialog and get the result
                        DialogResult result = openFileDialog.ShowDialog();

                        // if the user selected a file, save its path to the settings
                        if (result == DialogResult.OK)
                        {
                            controllerpath = openFileDialog.FileName;
                            Properties.Settings.Default.ControllerPath = controllerpath;
                            Properties.Settings.Default.Save();
                        }
                    }

                    // if the controllerpath is not null, start the controller app process
                    if (!string.IsNullOrEmpty(controllerpath))
                    {
                        Process.Start(controllerpath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't find Gamepad app: " + ex.Message);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                try
                {
                    // create a new instance of the OpenFileDialog class
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    // set the file filter to only show executable files
                    openFileDialog.Filter = "Executable Files|*.exe";

                    // display the OpenFileDialog and get the result
                    DialogResult result = openFileDialog.ShowDialog();

                    // if the user selected a file, save its path to the settings
                    if (result == DialogResult.OK)
                    {
                        string controllerpath = openFileDialog.FileName;
                        Properties.Settings.Default.ControllerPath = controllerpath;
                        Properties.Settings.Default.Save();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting controller app: " + ex.Message);
                }
            }
        }

        private void Headerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void Headerpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Headerpanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}

