using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management
{
    class Books
    {
        private string isbn;
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        private string summary;
        public string Summary
        {
            get { return summary; }
            set { summary = value; }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
    }
}
