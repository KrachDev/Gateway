using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway
{
    [Serializable]
    public class CustomSitesDatabase
    {
        public string Site_Name { get; set; }
        public string Site_Url { get; set; }
        public string Site_img { get; set; } //im tinking of adding custom img support but i think exraxting img from the site it self is better choice, do it a bit cpmplicated.
       // public string Site_Name { get; set; }

    }
}
