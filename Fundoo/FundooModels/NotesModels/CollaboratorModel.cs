using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FundooModels.Models
{
    public class CollaboratorModel
    {
        private int id;
        private string senderEmail;
        private string receiverEmail;
        private int notesId;

        public int Id { get => this.id; set => this.id = value; }

        [ForeignKey("RegisterModel")]
        public string SenderEmail { get => this.senderEmail; set => this.senderEmail = value; }

        public string ReceiverEmail { get => this.receiverEmail; set => this.receiverEmail = value; }

        public int NotesId { get => this.notesId; set => this.notesId = value; }
    }
}
