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
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace Gateway
{

    class SaveandLoad
    {
        private const string GAMES_FILE_PATH = "games.json";
        private const string APPS_FILE_PATH = "apps.json";

        public List<GameData> LoadGames()
        {
            List<GameData> gamesData = new List<GameData>();

            if (File.Exists(GAMES_FILE_PATH))
            {
                string gamesJson = File.ReadAllText(GAMES_FILE_PATH);
                gamesData = JsonConvert.DeserializeObject<List<GameData>>(gamesJson);
            }

            return gamesData;
        }

        public List<AppData> LoadApps()
        {
            List<AppData> appdData = new List<AppData>();

            if (File.Exists(APPS_FILE_PATH))
            {
                string appsJson = File.ReadAllText(APPS_FILE_PATH);
                appdData = JsonConvert.DeserializeObject<List<AppData>>(appsJson);
            }

            return appdData;
        }

        public void SaveGames(List<GameData> gamesData)
        {
            string gamesJson = JsonConvert.SerializeObject(gamesData);
            File.WriteAllText(GAMES_FILE_PATH, gamesJson);
        }

        public void SaveApps(List<AppData> appdData)
        {
            string appsJson = JsonConvert.SerializeObject(appdData);
            File.WriteAllText(APPS_FILE_PATH, appsJson);
        }
    }
}
