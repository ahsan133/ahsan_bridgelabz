// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// Collaborator model class.
    /// </summary>
    public class CollaboratorModel
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;

        /// <summary>
        /// The sender email
        /// </summary>
        private string senderEmail;

        /// <summary>
        /// The receiver email
        /// </summary>
        private string receiverEmail;

        /// <summary>
        /// The notes identifier
        /// </summary>
        private int notesId;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get => this.id; set => this.id = value; }

        /// <summary>
        /// Gets or sets the sender email.
        /// </summary>
        /// <value>
        /// The sender email.
        /// </value>
        [ForeignKey("RegisterModel")]
        public string SenderEmail { get => this.senderEmail; set => this.senderEmail = value; }

        /// <summary>
        /// Gets or sets the receiver email.
        /// </summary>
        /// <value>
        /// The receiver email.
        /// </value>
        public string ReceiverEmail { get => this.receiverEmail; set => this.receiverEmail = value; }

        /// <summary>
        /// Gets or sets the notes identifier.
        /// </summary>
        /// <value>
        /// The notes identifier.
        /// </value>
        public int NotesId { get => this.notesId; set => this.notesId = value; }
    }
}
