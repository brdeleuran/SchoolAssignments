using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails
{
    public class Drink
    {
        public string DrinkName { get; set; }
        public ICollection<Liquid> Liquids { get; set; }
        public ICollection<Garnish> Garnishes { get; set; }
    }
}
