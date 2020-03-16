// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooModels.NotesModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// Label model class.
    /// </summary>
    public class NotesModel
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;

        /// <summary>
        /// The title
        /// </summary>
        private string title;

        /// <summary>
        /// The description
        /// </summary>
        private string description;

        /// <summary>
        /// The image
        /// </summary>
        private string image;

        /// <summary>
        /// The archive
        /// </summary>
        private bool archive;

        /// <summary>
        /// The pin
        /// </summary>
        private bool pin;

        /// <summary>
        /// The trash
        /// </summary>
        private bool trash;

        /// <summary>
        /// The color
        /// </summary>
        private string color;

        /// <summary>
        /// The remainder
        /// </summary>
        private string remainder;

        /// <summary>
        /// The created time
        /// </summary>
        private DateTime createdTime;

        /// <summary>
        /// The modified time
        /// </summary>
        private DateTime modifiedTime;

        /// <summary>
        /// The identifier
        /// </summary>
        private int id;

        /// <summary>
        /// The index
        /// </summary>
        private int index;

        /// <summary>
        /// The label
        /// </summary>
        private String label;

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [ForeignKey("RegisterModel")]
        public string Email { get => this.email; set => this.email = value; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get => this.title; set => this.title = value; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get => this.description; set => this.description = value; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public string Image { get => this.image; set => this.image = value; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NotesModel"/> is archive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if archive; otherwise, <c>false</c>.
        /// </value>
        public bool Archive { get => this.archive; set => this.archive = value; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NotesModel"/> is pin.
        /// </summary>
        /// <value>
        ///   <c>true</c> if pin; otherwise, <c>false</c>.
        /// </value>
        public bool Pin { get => this.pin; set => this.pin = value; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NotesModel"/> is trash.
        /// </summary>
        /// <value>
        ///   <c>true</c> if trash; otherwise, <c>false</c>.
        /// </value>
        public bool Trash { get => this.trash; set => this.trash = value; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public string Color { get => this.color; set => this.color = value; }

        /// <summary>
        /// Gets or sets the remainder.
        /// </summary>
        /// <value>
        /// The remainder.
        /// </value>
        public string Remainder { get => this.remainder; set => this.remainder = value; }

        /// <summary>
        /// Gets or sets the created time.
        /// </summary>
        /// <value>
        /// The created time.
        /// </value>
        public DateTime CreatedTime { get => this.createdTime; set => this.createdTime = value; }

        /// <summary>
        /// Gets or sets the modified time.
        /// </summary>
        /// <value>
        /// The modified time.
        /// </value>
        public DateTime ModifiedTime { get => this.modifiedTime; set => this.modifiedTime = value; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get => this.id; set => this.id = value; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int Index { get => this.index; set => this.index = value; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Label { get => this.label; set => this.label = value; }
    }
}