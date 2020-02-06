// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooTesting
{
    using FundooApp.Controllers;
    using FundooManager.Interface;
    using FundooModels.Models;
    using Moq;
    using Xunit;

    /// <summary>
    /// This class is for test cases of Collaborator controller.
    /// </summary>
    public class CollaboratorTest
    {
        /// <summary>
        /// Adds the collaborator.
        /// </summary>
        [Fact]
        public void AddCollaborator()
        {
            var services = new Mock<ICollaboratorManager>();
            var controller = new CollaboratorController(services.Object);
            var input = new CollaboratorModel()
            {
                SenderEmail = "ahsan@gmail.com",
                ReceiverEmail = "asd@gmail.com",
                NotesId = 1
            };
            var data = controller.AddCollaborator(input);
            Assert.NotNull(data);
        }

        /// <summary>
        /// Removes the collaborator.
        /// </summary>
        [Fact]
        public void RemoveCollaborator()
        {
            var services = new Mock<ICollaboratorManager>();
            var controller = new CollaboratorController(services.Object);
            var data = controller.RemoveCollaborator(2);
            Assert.NotNull(data);
        }
    }
}
