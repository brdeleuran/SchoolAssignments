using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumDropVending
{
    class Gum //Creates a list for each of the different flavors of gum and then creates a get: set for each list for access to the lists
    {
        static List<string> blueberry = new List<string>();
        static List<string> blackberry = new List<string>();
        static List<string> tuttiFrutti = new List<string>();
        static List<string> orange = new List<string>();
        static List<string> strawberry = new List<string>();
        static List<string> apple = new List<string>();

        #region GetSet
        public List<string> Blueberry
        {
            get
            {
                return blueberry;
            }
            set
            {
                blueberry = value;
            }
        }

        public List<string> Blackberry
        {
            get
            {
                return blackberry;
            }
            set
            {
                blackberry = value;
            }
        }

        public List<string> TuttiFrutti
        {
            get
            {
                return tuttiFrutti;
            }
            set
            {
                tuttiFrutti = value;
            }
        }

        public List<string> Orange
        {
            get
            {
                return orange;
            }
            set
            {
                orange = value;
            }
        }

        public List<string> Strawberry
        {
            get
            {
                return strawberry;
            }
            set
            {
                strawberry = value;
            }
        }

        public List<string> Apple
        {
            get
            {
                return apple;
            }
            set
            {
                apple = value;
            }
        }
        #endregion

        public Gum()
        {

        }
        
    }
}
