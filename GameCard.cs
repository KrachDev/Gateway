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
namespace Gateway
{
    public partial class GameCard : Form
    {
        
       
            public string gameName;
        private string api = "&key=e8d2d271f9704188bdefbdfc9e2038ae";

            public GameCard()
            {
                InitializeComponent();

            

        }



        private async void PBgamecover_Click(object sender, EventArgs e)
        {
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




        private string GetSteamAppId(string gameName)
        {

            string apiUrl = $"https://api.steampowered.com/ISteamApps/GetAppList/v2/";

            // Make a request to the Steam API to get a list of apps
            HttpWebRequest request = WebRequest.Create(apiUrl) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"API request failed with status code {response.StatusCode}");

                // Read the response and parse the JSON to find the Steam App ID for the specified game
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseText = reader.ReadToEnd();
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                serializer.MaxJsonLength = Int32.MaxValue;
                dynamic json = serializer.Deserialize<object>(responseText);

                foreach (dynamic app in json["applist"]["apps"])
                {
                    if (app["name"].ToString().Equals(gameName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return app["appid"].ToString();
                    }
                }
            }

            throw new Exception($"Game not found: {gameName}");
        }


        private async void PoplateBTN_Click(object sender, EventArgs e)
        {
            string gameName = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the game", "Game Name", "Elden Ring");
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
            gmfolbl.Text =  name;

            // Release date
            string releaseDate = responseObject.results[0].released;
            svlolbl.Text = releaseDate;

            // Rating
            double rating = responseObject.results[0].rating;
            Rlbl.Text = rating.ToString();

            // Description
            string description = responseObject.results[0].description_raw;
            GameDescriptionLBL.Text = description;
        }








        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void waveViewer1_Load(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        

        private void GameCard_Load(object sender, EventArgs e)
        {
            
        }
    }


}
