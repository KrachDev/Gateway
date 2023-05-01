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

namespace Gateway
{
    public partial class GameCard : Form
    {
        private WebView2 webView; // Define webView as a class-level variable

        public GameCard()
        {
            InitializeComponent();
            // Create a new instance of the WebView2 control
            webView = new WebView2();

            // Set the size and position of the control on the form
            webView.Size = new Size(800, 600);
            webView.Location = new Point(10, 10);

            // Add the control to the form
            Controls.Add(webView);
        }

        private async void CoverSearchBTN_Click(object sender, EventArgs e)
        {
            

            // Navigate to the desired URL
            webView.CoreWebView2.Navigate("https://www.google.com");

            // Initialize the WebView2 control
            await webView.EnsureCoreWebView2Async();

            // Add the control to the form
            Controls.Add(webView);
        }

        private async void LoadImage(string imageUrl)
        {
            // Initialize the WebView2 control
            await webView.EnsureCoreWebView2Async();
            imageUrl = "https://cdn.vox-cdn.com/thumbor/J79L5C2MrbeuqsnKF9xgSZQzkwY=/0x0:3840x2160/920x613/filters:focal(1613x773:2227x1387):format(webp)/cdn.vox-cdn.com/uploads/chorus_image/image/71603984/kratos_cave2.0.jpg";
            // Navigate to the URL that contains the image
            webView.CoreWebView2.Navigate(imageUrl);

            // Wait for the page to finish loading
            webView.CoreWebView2.DOMContentLoaded += async (sender, args) =>
            {
                // Get the image element
                string imageScript = @"document.querySelector('img')";
                var imageElement = await webView.CoreWebView2.ExecuteScriptAsync(imageScript);

                // Get the image source URL
                string imageUrlScript = @"document.querySelector('img').src";
                var imageUrlResult = await webView.CoreWebView2.ExecuteScriptAsync(imageUrlScript);
                string imageUrlFromPage = imageUrlResult.ToString();

                // Load the image into the PictureBox control
                PBgamecover.Load(imageUrlFromPage);
            };
        }


        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async void PBgamecover_Click(object sender, EventArgs e)
        {
            // Get the image URL for the specified game
            string imageUrl = await GetGameImageUrlAsync("Elden Ring");

            // Load the image from the URL
            Image image = await LoadImageAsync(imageUrl);

            // Set the Image property of the picture box
            PBgamecover.Image = image;
        }

        private async Task<string> GetGameImageUrlAsync(string gameTitle)
        {
            // Build the API query to retrieve the game info
            string apiUrl = $"https://www.pcgamingwiki.com/w/api.php?action=cargoquery&tables=Infobox_game&fields=Infobox_game.Cover_URL&where=Infobox_game._pageName%3D%22{gameTitle}%22&format=json";

            // Send the API request
            using (var httpClient = new HttpClient())
            using (var response = await httpClient.GetAsync(apiUrl))
            {
                // Parse the JSON response
                var json = await response.Content.ReadAsStringAsync();
                var data = JObject.Parse(json)["cargoquery"]?.FirstOrDefault()?["title"];

                // Return the cover URL, or null if it wasn't found
                return data?["Cover_URL"]?.ToString();
            }
        }

        private async Task<Image> LoadImageAsync(string imageUrl)
        {
            // Load the image asynchronously
            using (var httpClient = new HttpClient())
            using (var response = await httpClient.GetAsync(imageUrl))
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                return Image.FromStream(stream);
            }
        }




        private void WBreloadBTN_Click(object sender, EventArgs e)
        {
            browsWB.Refresh();
        }

        private void backWBBTN_Click(object sender, EventArgs e)
        {
            browsWB.GoBack();
        }

        private void ForwardWBBTN_Click(object sender, EventArgs e)
        {
            browsWB.GoForward();
        }
    }

}
