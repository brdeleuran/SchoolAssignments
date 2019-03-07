using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public int pages;
        public string author;
        public int year;
        public string title;

        static List<Book> library = new List<Book>();
        public List<Book> Library { get { return library; } }


        
        

        public Book()
        {

        }

        public Book(int pages, string author, int year, string title)
        {
            this.pages = pages;
            this.author = author;
            this.year = year;
            this.title = title;
            library.Add(this);
        }
    }
}
