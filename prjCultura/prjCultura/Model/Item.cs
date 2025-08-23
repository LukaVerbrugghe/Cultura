using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCultura.Model
{
    public class Item
    {
        public int ID { get; set; }
        public int listID { get; set; }
        public string title { get; set; }
        public int index { get; set; }
        public string type { get; set; }
        public string review { get; set; }
        public int stars { get; set; }
        public int prequelID { get; set; }
        public int sequelID { get; set; }
    }
}
