using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    class Book
    {
        public string bookName { get; set; }
        public string authorName { get; set; }
        public string dateOfPublishing { get; set; }
        public string category { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Book(string bookName, string authorName, string dateOfPublishing, string category, double price, int quantity)
        {
            this.bookName = bookName; 
            this.authorName = authorName;   
            this.dateOfPublishing = dateOfPublishing;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
        }
    }

}
