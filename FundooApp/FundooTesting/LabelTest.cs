// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooTesting
{
    using FundooApp.Controllers;
    using FundooManager.Interface;
    using FundooModels.NotesModels;
    using Moq;
    using Xunit;

    /// <summary>
    /// This class is for test cases of Label controller.
    /// </summary>
    public class LabelTest
    {
        /// <summary>
        /// Adds the label.
        /// </summary>
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

        /// <summary>
        /// Updates the label.
        /// </summary>
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

        /// <summary>
        /// Deletes the label.
        /// </summary>
        [Fact]
        public void DeleteLabel()
        {
            var services = new Mock<ILabelManager>();
            var controller = new LabelController(services.Object);
            var data = controller.DeleteLabel(2);
            Assert.NotNull(data);
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
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
