// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooTesting
{  
    using FundooApp.Controllers;
    using FundooManager.Manager;
    using FundooModels.NotesModel;
    using Moq;
    using Xunit;

    /// <summary>
    /// This class is for test cases of Notes controller.
    /// </summary>
    public class NotesTest
    {
        /// <summary>
        /// Adds the notes.
        /// </summary>
        [Fact]
        public void AddNotes()
        {
            var services = new Mock<INotesManager>();
            var controller = new NotesController(services.Object);
            var input = new NotesModel()
            {
                Email = "asd@gmail.com",
                Title = "hi",
                Description = "my name is ahsan",
                Archive = false,
                Pin = false,
                Trash = false,
                Remainder = "Get up",
                Color = "blue"
            };
            var data = controller.AddNotes(input);
            Assert.NotNull(data);
        }

        /// <summary>
        /// Updates the notes.
        /// </summary>
        [Fact]
        public void UpdateNotes()
        {
            var services = new Mock<INotesManager>();
            var controller = new NotesController(services.Object);
            var input = new NotesModel()
            {
                Id = 2,
                Email = "asd@gmail.com",
                Title = "hi",
                Description = "my name is ahsan",
                Archive = false,
                Pin = false,
                Trash = false,
                Remainder = "Get up",
                Color = "blue"
            };
            var data = controller.UpdateNotes(input);
            Assert.NotNull(data);
        }

        /// <summary>
        /// Removes the notes.
        /// </summary>
        [Fact]
        public void RemoveNotes()
        {
            var services = new Mock<INotesManager>();
            var controller = new NotesController(services.Object);
            var data = controller.RemoveNotes(2);
            Assert.NotNull(data);
        }

        /// <summary>
        /// Gets the notes.
        /// </summary>
        [Fact]
        public void GetNotes()
        {
            var services = new Mock<INotesManager>();
            var controller = new NotesController(services.Object);
            var data = controller.GetNotes("asd@gmail.com");
            Assert.NotNull(data);
        }

        /// <summary>
        /// Determines whether the specified identifier is archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void IsArchive(int id)
        {
            var services = new Mock<INotesManager>();
            var controller = new NotesController(services.Object);
            var data = controller.IsArchive(id);
            Assert.NotNull(data);
        }

        /// <summary>
        /// Determines whether the specified identifier is pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void IsPin(int id)
        {
            var services = new Mock<INotesManager>();
            var controller = new NotesController(services.Object);
            var data = controller.IsPin(id);
            Assert.NotNull(data);
        }

        /// <summary>
        /// Determines whether the specified identifier is trash.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void IsTrash(int id)
        {
            var services = new Mock<INotesManager>();
            var controller = new NotesController(services.Object);
            var data = controller.IsTrash(id);
            Assert.NotNull(data);
        }

        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Restore(int id)
        {
            var services = new Mock<INotesManager>();
            var controller = new NotesController(services.Object);
            var data = controller.Restore(id);
            Assert.NotNull(data);
        }
    }
}
