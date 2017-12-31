using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management
{
    class BooksNaver
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
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

        private string discount;
        public string Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private string publisher;
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private string pubdate;
        public string Pubdate
        {
            get { return pubdate; }
            set { pubdate = value; }
        }

        private string isbn;
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
