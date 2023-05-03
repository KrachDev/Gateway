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
    public partial class SearchForm : Form
    {
        public string gameName;
        private string api = "&key=e8d2d271f9704188bdefbdfc9e2038ae";
        // GAMES DATA
        private const string GAMES_FILE_PATH = "games.json";
        private List<GameData> gamesData = new List<GameData>();
        //APPS DATA
        private const string APPS_FILE_PATH = "apps.json";
        private List<AppData> appdData = new List<AppData>();
        private GameData gameData;
        public SearchForm()
        {
            InitializeComponent();
            LoadGames();
            if (gamesData.Count > 0)
            {
                gameData = gamesData[0];
                SearchBar.Text = gameData.Name;
            }
        }

        private void AddButton(string gameName, Image coverImage)
        {
            // Create a new Guna2Button to display the game
            Guna2Button gameButton = new Guna2Button();
            gameButton.Text = gameName;
            gameButton.Size = new Size(100, 100);
            gameButton.Padding = new Padding(10);
            gameButton.TextAlign = HorizontalAlignment.Left;
            gameButton.ImageAlign = HorizontalAlignment.Center;
            gameButton.BackgroundImageLayout = ImageLayout.Stretch;
            gameButton.FillColor = Color.Indigo;

            // Create a new PictureBox to display the cover image
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = gameButton.ClientSize;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = coverImage;

            // Add the PictureBox to the button
            gameButton.Controls.Add(pictureBox);

            gameButton.Tag = gameName;
            gameButton.MouseDown += appButton_MouseUp;

            // Add the button to the FlowLayoutPanel
            SuggestionsPanel.Controls.Add(gameButton);
        }


        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            // Clear existing games from the FlowLayoutPanel
            SuggestionsPanel.Controls.Clear();

            // Make the API call to get games matching the search query
            HttpClient client = new HttpClient();
            string url = "https://api.rawg.io/api/games?search=" + SearchBar.Text + api;
            HttpResponseMessage response = await client.GetAsync(url);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            dynamic responseObject = JsonConvert.DeserializeObject(jsonResponse);

            // Loop through the results and add each game to the FlowLayoutPanel
            foreach (var result in responseObject.results)
            {
                string gameName = result.name;

                // Set the background image of the button to the game's cover image
                string coverUrl = result.background_image;
                if (!string.IsNullOrEmpty(coverUrl))
                {
                    byte[] coverData = await client.GetByteArrayAsync(coverUrl);
                    MemoryStream coverStream = new MemoryStream(coverData);
                    Image coverImage = Image.FromStream(coverStream);

                    // Add a button to the FlowLayoutPanel for this game
                    AddButton(gameName, coverImage);
                }
            }
        }
        private void appButton_MouseUp(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}
