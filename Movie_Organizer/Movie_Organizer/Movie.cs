using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;

namespace Movie_Organizer
{
    class Movie : Item
    {
        public string filePath{ get; set; }

        public string summary { get; set; }
    }
}
