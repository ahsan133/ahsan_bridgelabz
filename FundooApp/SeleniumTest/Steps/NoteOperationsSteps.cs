using SeleniumTest.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTest.Steps
{
    [Binding]
    public class NoteOperationsSteps
    {
        [When(@"I click on add remainder")]
        public void WhenIClickOnAddRemainder()
        {
            System.Threading.Thread.Sleep(3000);
            ((NoteOperationPage)PropertyCollection.CurrentPage).AddRemainder();
        }

        [Then(@"the remainder is added")]
        public void ThenTheRemainderIsAdded()
        {
            Console.WriteLine("remainder added");
        }

        [When(@"I type email")]
        public void WhenITypeEmail(Table table)
        {
            System.Threading.Thread.Sleep(3000);
            dynamic detail = table.CreateDynamicInstance();
            ((NoteOperationPage)PropertyCollection.CurrentPage).AddCollaborator(detail.Email);
        }
        
        [When(@"Click on save button")]
        public void WhenClickOnSaveButton()
        {
            ((NoteOperationPage)PropertyCollection.CurrentPage).ClickSave();
        }

        [Then(@"the collaborator is added")]
        public void ThenTheCollaboratorIsAdded()
        {
            Console.WriteLine("collaborator added");
        }

        [When(@"I click on a color")]
        public void WhenIClickOnAColor()
        {
            System.Threading.Thread.Sleep(3000);
            ((NoteOperationPage)PropertyCollection.CurrentPage).ChangeColor();
            System.Threading.Thread.Sleep(3000);
        }

        [Then(@"the color is changed")]
        public void ThenTheColorIsChanged()
        {
            Console.WriteLine("color changed");
        }

        [When(@"I click on add label")]
        public void WhenIClickOnAddLabel()
        {
            System.Threading.Thread.Sleep(3000);
            ((NoteOperationPage)PropertyCollection.CurrentPage).AddLabelClick();
        }
        
        [When(@"Enter the label")]
        public void WhenEnterTheLabel(Table table)
        {
            dynamic detail = table.CreateDynamicInstance();
            ((NoteOperationPage)PropertyCollection.CurrentPage).AddLabel(detail.Label);
        }

        [Then(@"the label is added")]
        public void ThenTheLabelIsAdded()
        {
            Console.WriteLine("label added");
        }

        [When(@"I click on add archive")]
        public void WhenIClickOnAddArchive()
        {
            System.Threading.Thread.Sleep(3000);
            ((NoteOperationPage)PropertyCollection.CurrentPage).AddArchive();
        }
        
        [Then(@"the note is added to archive")]
        public void ThenTheNoteIsAddedToArchive()
        {
            Console.WriteLine("added to archive");
        }
    }
}
