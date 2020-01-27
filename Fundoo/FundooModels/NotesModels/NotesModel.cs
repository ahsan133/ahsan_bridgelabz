using System;
using System.Collections.Generic;
using System.Text;

namespace FundooModels.NotesModel
{
    public class NotesModel
    {
        private string email;
        private string title;
        private string image;
        private bool archive;
        private bool pin;
        private string trash;
        private string color;
        private string remainder;
        private DateTime createdTime;
        private DateTime modifiedTime;

        public string Email { get => this.email; set => this.email = value; }
        public string Title { get => this.title; set => this.title = value; }
        public string Image { get => this.image; set => this.image = value; }
        public bool Archive { get => this.archive; set => this.archive = value; }
        public bool Pin { get => this.pin; set => this.pin = value; }
        public string Trash { get => this.trash; set => this.trash = value; }
        public string Color { get => this.color; set => this.color = value; }
        public string Remainder { get => this.remainder; set => this.remainder = value; }
        public DateTime CreatedTime { get => this.createdTime; set => this.createdTime = value; }
        public DateTime ModifiedTime { get => this.modifiedTime; set => this.modifiedTime = value; }
    }
}
