using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Garnish
    {
        public int GarnishID { get; set; }
        public string GarnishName { get; set; }
        public string GarnishAmount { get; set; }
        public bool GarnishEdible { get; set; }
        public Drink Drink { get; set; }
    }
}
