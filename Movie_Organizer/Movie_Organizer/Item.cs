using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Movie_Organizer
{
    class Item
    {
        public int id { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public List<string> genre { get; set; }
    }
}
