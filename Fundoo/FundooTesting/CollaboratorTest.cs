using Fundoo.Controllers;
using FundooManager.Interface;
using FundooModels.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FundooTesting
{
    public class CollaboratorTest
    {
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
