using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Drink
    {
        public int DrinkID { get; set; }
        public string DrinkName { get; set; }
        public ICollection<Alcohol> Liquids { get; set; }
        public ICollection<Garnish> Garnishes { get; set; }
        public ICollection<Mixer> Mixers { get; set; }
    }
}
