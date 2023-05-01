using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Linq;

namespace Gateway
{
    public class GameData
    {
        public string GameId { get; set; }
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public string GameFolder { get; set; }
        public string SaveFolder { get; set; }
        public string GameSize { get; set; }
        public string GameTimeString
        {
            get { return GameTime.ToString(); }
            set { GameTime = TimeSpan.Parse(value); }
        }

        [JsonIgnore]
        public TimeSpan GameTime { get; set; }
       
    }

}
