using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Alcohol
    {
        public int AlcoholID { get; set; }
        public string AlcoholName { get; set; }
        public string AlcoholAmount { get; set; }
        public Drink Drink { get; set; }
    }
}
