using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTest.Steps
{
    [Binding]
    public class AddNoteSteps
    {
        [When(@"I give title and description")]
        public void WhenIGiveTitleAndDescription(Table table)
        {
            ((AddNotePage)PropertyCollection.CurrentPage).ClickOnNote();
            dynamic detail = table.CreateDynamicInstance();
            PropertyCollection.CurrentPage = ((AddNotePage)PropertyCollection.CurrentPage).GiveValues(detail.Title, detail.Description);
        }

        [Then(@"the note should be added")]
        public void ThenTheNoteShouldBeAdded()
        {
            Console.WriteLine("note added");
        }
    }
}
