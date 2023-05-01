using System;
using System.IO;
using RestSharp;
using Newtonsoft.Json;
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
using Microsoft.Web.WebView2.WinForms;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Web.Script.Serialization;
using System.Net.Http.Headers;
using AForge.Video.DirectShow;
using System.Runtime.InteropServices;

namespace Gateway
{
    public partial class GameCard : Form
    {
        private bool isDragging = false;
        private Point lastLocation;
        private Stopwatch gameTimer = new Stopwatch();
        private Timer timer = new Timer();
        private Timer updateTimer = new Timer();
        private TimeSpan elapsedTime = TimeSpan.Zero;
        public string gameName;
        private string api = "&key=e8d2d271f9704188bdefbdfc9e2038ae";
        // GAMES DATA
        private const string GAMES_FILE_PATH = "games.json";
        private List<GameData> gamesData = new List<GameData>();
        //APPS DATA
        private const string APPS_FILE_PATH = "apps.json";
        private List<AppData> appdData = new List<AppData>();
        private GameData gameData;
        public GameCard(GameData gameData)
        {
            InitializeComponent();
            LoadGames();
            LoadApps();
            this.gameData = gameData;
            // Initialize labels with game data
            Nlbl.Text = gameData.Name;
            gmfolbl.Text = gameData.GameFolder;
            SZlbl.Text = gameData.GameSize;
            svlolbl.Text = gameData.SaveFolder;

            TSpentlbl.Text = gameData.GameTime.ToString();

            

        }

        private async void PBgamecover_Click(object sender, EventArgs e)
        {
            /*
            string gameName3 = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the game", "Game Name", "Elden Ring");
            HttpClient client = new HttpClient();
            string url = "https://api.rawg.io/api/games?search=" + gameName3 + api;
            HttpResponseMessage response = await client.GetAsync(url);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            dynamic responseObject = JsonConvert.DeserializeObject(jsonResponse);
            string coverUrl = responseObject.results[0].background_image;
            Image image = DownloadImage(coverUrl);
            PBgamecover.Image = ResizeImage(image, PBgamecover.Size);
            //grad.BackgroundImage = PBgamecover.Image;
            */
        }
        private Image DownloadImage(string url)
        {
            using (WebClient client = new WebClient())
            {
                byte[] imageData = client.DownloadData(url);
                using (MemoryStream stream = new MemoryStream(imageData))
                {
                    return Image.FromStream(stream);
                }
            }
        }
        private Image ResizeImage(Image image, Size size)
        {
            Bitmap result = new Bitmap(size.Width, size.Height);
            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.DrawImage(image, new Rectangle(Point.Empty, size));
            }
            return result;
        }
        private async void PoplateBTN_Click(object sender, EventArgs e)
        {
            AutoFill();
        }
        public async void AutoFill()
        {
            string gameName = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the game", "Game Name", gameData.Name);
            HttpClient client = new HttpClient();
            string url = "https://api.rawg.io/api/games?search=" + gameName + api;
            HttpResponseMessage response = await client.GetAsync(url);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            dynamic responseObject = JsonConvert.DeserializeObject(jsonResponse);
            string coverUrl = responseObject.results[0].background_image;
            Image image = DownloadImage(coverUrl);
            PBgamecover.Image = ResizeImage(image, PBgamecover.Size);

            // Game name
            string name = responseObject.results[0].name;
            Nlbl.Text = name;

            // Release date
            string releaseDate = responseObject.results[0].released;
            Rdate.Text = releaseDate;

            // Rating
            float rating = responseObject.results[0].rating;
            Rlbl.Value = rating;

            // Description
            string description = responseObject.results[0].description_raw;
            GameDescriptionLBL.Text = description;

            //afterwards
            gameData.Name = gameName;
        }
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GameCard_Load(object sender, EventArgs e)
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
                    appdData.Add(appsData);
                }
            }
        }
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        private void LaunchBTN_Click(object sender, EventArgs e)
        {
            

            // Start the game timer
            gameTimer.Start();

            // Launch the game and add event handler for Process.Exited event
            Process process = new Process();
            process.StartInfo.FileName = gameData.GameFolder;
            process.EnableRaisingEvents = true;
            process.Exited += Process_Exited;
            process.Start();

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

        private void ogamefolderBTN_Click(object sender, EventArgs e)
        {
            string gameFolder = Path.GetDirectoryName(Path.GetDirectoryName(gameData.GameFolder));
            Process.Start(gameFolder);
        }

        private void GameCard_Click(object sender, EventArgs e)
        {
            TSpentlbl.Text = gameData.GameTime.ToString();
        }
    }
}
