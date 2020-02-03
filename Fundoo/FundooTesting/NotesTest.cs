using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using FundooManager.Manager;
using Fundoo.Controllers;
using FundooModels.NotesModel;

namespace FundooTesting
{
    public class NotesTest
    {
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

        [Fact]
        public void RemoveNotes()
        {
            var services = new Mock<INotesManager>();
            var controller = new NotesController(services.Object);
            var data = controller.RemoveNotes(2);
            Assert.NotNull(data);
        }

        [Fact]
        public void GetNotes()
        {
            var services = new Mock<INotesManager>();
            var controller = new NotesController(services.Object);
            var data = controller.GetNotes("asd@gmail.com");
            Assert.NotNull(data);
        }

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
