using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FundooModels.NotesModels
{
    public class LabelModel
    {
        private string email;
        private string label;
        private int id;

        [Key]
        public string Email { get => this.email; set => this.email = value; }
        public string Label { get => this.label; set => this.label = value; }
        public int Id { get => this.id; set => this.id = value; }
    }
}
