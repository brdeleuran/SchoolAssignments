using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Mixer
    {
        public int MixerID { get; set; }
        public string MixerName { get; set; }
        public string MixerAmount { get; set; }
        public Drink Drink { get; set; }
    }
}
