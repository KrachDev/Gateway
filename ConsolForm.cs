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
using SharpDX.XInput;
using SharpDX;
using System.Linq;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace Gateway
{
    public partial class ConsolForm : Form
    {
        // GAMES DATA
        private const string GAMES_FILE_PATH = "games.json";
        private List<GameData> gamesData = new List<GameData>();
        //APPS DATA
        private const string APPS_FILE_PATH = "apps.json";
        private List<AppData> appdData = new List<AppData>();
        //CONTROLLRE
        private Controller controller;

        public ConsolForm()
        {
            InitializeComponent();
            LoadGames();
            LoadApps();
            // Initialize the XInputController
            controller = new Controller(UserIndex.One);
            HandleGamepadInput();
        }

        private void HandleGamepadInput()
        {
            // Get the current gamepad state
            State state = controller.GetState();

            // Check if the gamepad is connected
            if (state.PacketNumber == 0)
            {
                return;
            }

            // Check if the A button is pressed
            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A))
            {
                // Perform the action associated with the currently selected button
                if (GamesFlow2.Controls.OfType<Guna2Button>().Any(x => x.Focused))
                {
                    GameButton_Click(GamesFlow2.Controls.OfType<Guna2Button>().FirstOrDefault(x => x.Focused), EventArgs.Empty);
                }
                else if (AppsFlow2.Controls.OfType<Guna2Button>().Any(x => x.Focused))
                {
                    appButton_Click(AppsFlow2.Controls.OfType<Guna2Button>().FirstOrDefault(x => x.Focused), EventArgs.Empty);
                }
            }

            // Check if the DPad up button is pressed
            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp))
            {
                // Select the previous button in the currently focused FlowLayoutPanel
                if (GamesFlow2.Controls.OfType<Guna2Button>().Any(x => x.Focused))
                {
                    int index = GamesFlow2.Controls.OfType<Guna2Button>().ToList().IndexOf(GamesFlow2.Controls.OfType<Guna2Button>().FirstOrDefault(x => x.Focused));
                    if (index > 0)
                    {
                        GamesFlow2.Controls.OfType<Guna2Button>().ToList()[index - 1].Select();
                    }
                }
                else if (AppsFlow2.Controls.OfType<Guna2Button>().Any(x => x.Focused))
                {
                    int index = AppsFlow2.Controls.OfType<Guna2Button>().ToList().IndexOf(AppsFlow2.Controls.OfType<Guna2Button>().FirstOrDefault(x => x.Focused));
                    if (index > 0)
                    {
                        AppsFlow2.Controls.OfType<Guna2Button>().ToList()[index - 1].Select();
                    }
                }
            }

            // Check if the DPad down button is pressed
            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown))
            {
                // Select the next button in the currently focused FlowLayoutPanel
                if (GamesFlow2.Controls.OfType<Guna2Button>().Any(x => x.Focused))
                {
                    int index = GamesFlow2.Controls.OfType<Guna2Button>().ToList().IndexOf(GamesFlow2.Controls.OfType<Guna2Button>().FirstOrDefault(x => x.Focused));
                    if (index < GamesFlow2.Controls.OfType<Guna2Button>().Count() - 1)
                    {
                        GamesFlow2.Controls.OfType<Guna2Button>().ToList()[index + 1].Select();
                    }
                }
                else if (AppsFlow2.Controls.OfType<Guna2Button>().Any(x => x.Focused))
                {
                    int index = AppsFlow2.Controls.OfType<Guna2Button>().ToList().IndexOf(AppsFlow2.Controls.OfType<Guna2Button>().FirstOrDefault(x => x.Focused));
                    if (index < AppsFlow2.Controls.OfType<Guna2Button>().Count() - 1)
                    {
                        AppsFlow2.Controls.OfType<Guna2Button>().ToList()[index + 1].Select();
                    }
                }
            }// Check if the DPad left button is pressed
            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft))
            {
                // Navigate back to the main menu
               // if (backButton.Focused)
                //{
                //    backButton.PerformClick();
               // }
            }
        }


        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
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

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        private void AddGameButton(GameData gameData)
        {
            Guna2Button gameButton = new Guna2Button();
            gameButton.Image = Icon.ExtractAssociatedIcon(gameData.GameFolder).ToBitmap();
            gameButton.Tag = gameData;
            gameButton.Size = new Size(70, 70);
            gameButton.FillColor = Color.Transparent;
            gameButton.Click += GameButton_Click;
            gameButton.MouseDown += GameButton_MouseUp; // new event handler for MouseDown
            GamesFlow2.Controls.Add(gameButton);
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
            AppsFlow2.Controls.Add(appButton);
        }

        private void appButton_MouseUp(object sender, MouseEventArgs e)
        {
            // Check if the middle mouse button is clicked
            if (e.Button == MouseButtons.Middle)
            {

                // Remove the button from the FlowLayoutPanel
                Guna2Button appBtn = (Guna2Button)sender;
                AppsFlow2.Controls.Remove(appBtn);
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
            GameData gameData = (GameData)((Guna2Button)sender).Tag;

            // Start a new process to launch the game
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = gameData.GameFolder;
            startInfo.WorkingDirectory = Path.GetDirectoryName(gameData.GameFolder);
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }
        private void GameButton_MouseUp(object sender, MouseEventArgs e)
        {


            // Check if the middle mouse button is clicked
            if (e.Button == MouseButtons.Middle)
            {

                // Remove the button from the FlowLayoutPanel
                Guna2Button gameBtn = (Guna2Button)sender;
                GamesFlow2.Controls.Remove(gameBtn);
                gameBtn.Dispose(); // Optional: dispose the removed control

                // Remove the game data from the list
                GameData gameData = (GameData)gameBtn.Tag;
                gamesData.Remove(gameData);

                // Save games data to JSON file
                string gamesJson = JsonConvert.SerializeObject(gamesData);
                File.WriteAllText(GAMES_FILE_PATH, gamesJson);
            }
        }

        private void ConsolForm_Load(object sender, EventArgs e)
        {
            // Initialize the Controller object
            controller = new Controller(UserIndex.One);

            // Subscribe to the ButtonDown and ButtonUp events
           // controller.ButtonDown += Controller_ButtonDown;
            //controller.ButtonUp += Controller_ButtonUp;
        }

        private void GamepadButton_Click(object sender, EventArgs e)
        {

        }

        // Implement the event handlers
        // private void Controller_ButtonDown(object sender, GamepadButtonEventArgs e)
        // {
        // HandleGamepadInput();
        // }

        // private void Controller_ButtonUp(object sender, GamepadButtonEventArgs e)
        ///{
        // Do nothing
        // }
    }
}
