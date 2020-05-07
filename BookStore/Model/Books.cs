using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Books
    {
        private string image;
        private string name;
        private string authorName;
        private int price;

        public string Image { get => this.image; set => this.image = value; }
        public string Name { get => this.name; set => this.name = value; }
        public string AuthorName { get => this.authorName; set => this.authorName = value; }
        public int Price { get => this.price; set => this.price = value; }
    }
}
