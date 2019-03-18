using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Info
    {
        static List<Stack<Product>> productList = new List<Stack<Product>>(); //Creates a list of stacks for the different products
        static Stack<Product> vendingSlot; 

        public List<Stack<Product>> ProductList //A get: set for the list of stacks so other methods can access it
        { 
            get
            {
                return productList;
            }
            set
            {
                productList = value;
            }
        }

        public Info() //adds stacks to the list
        {
            for (int i = 0; i < 4; i++)
            {
                productList.Add(vendingSlot = new Stack<Product>());
            }
        }
    }
}
