using Fundoo.Controllers;
using FundooManager.Interface;
using FundooModels.NotesModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FundooTesting
{
    public class LabelTest
    {
        [Fact]
        public void AddLabel()
        {
            var services = new Mock<ILabelManager>();
            var controller = new LabelController(services.Object);
            var input = new LabelModel()
            {
                Email = "abc@gmail.com",
                Label = "notes"
            };
            var data = controller.AddLabel(input);
            Assert.NotNull(data);
        }

        [Fact]
        public void UpdateLabel()
        {
            var services = new Mock<ILabelManager>();
            var controller = new LabelController(services.Object);
            var input = new LabelModel()
            {
                Id = 2,
                Email = "abc@gmail.com",
                Label = "notesss"
            };
            var data = controller.UpdateLabel(input);
            Assert.NotNull(data);
        }

        [Fact]
        public void DeleteLabel()
        {
            var services = new Mock<ILabelManager>();
            var controller = new LabelController(services.Object);
            var data = controller.DeleteLabel(2);
            Assert.NotNull(data);
        }

        [Fact]
        public void GetLabel()
        {
            var services = new Mock<ILabelManager>();
            var controller = new LabelController(services.Object);
            var data = controller.GetLabel("abc@gmail.com");
            Assert.NotNull(data);
        }
    }
}
