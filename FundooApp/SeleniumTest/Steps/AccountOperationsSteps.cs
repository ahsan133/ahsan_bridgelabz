using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTest.Steps
{
    [Binding]
    public class AccountOperationsSteps 
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I have navigated to the Login page")]
        public void GivenIHaveNavigatedToTheLoginPage()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/login");
        }

        [When(@"I type the email and password")]
        public void WhenITypeTheEmailAndPassword(Table table)
        {
            LoginPage page = new LoginPage(driver);

            dynamic detail = table.CreateDynamicInstance();
            page.Login(detail.Email, detail.Password);

        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            LoginPage page = new LoginPage(driver);
            PropertyCollection.CurrentPage = page.ClickButton();
        }

        [When(@"I click on notes")]
        public void WhenIClickOnNotes()
        {
            ((AccountOperationPage)PropertyCollection.CurrentPage).clickNote();
        }
        
        [When(@"I click on Remainders")]
        public void WhenIClickOnRemainders()
        {
            ((AccountOperationPage)PropertyCollection.CurrentPage).clickRemainder();
        }
        
        [When(@"I click on Archive")]
        public void WhenIClickOnArchive()
        {
            ((AccountOperationPage)PropertyCollection.CurrentPage).clickArchive();
        }
        
        [When(@"I click on Trash")]
        public void WhenIClickOnTrash()
        {
            ((AccountOperationPage)PropertyCollection.CurrentPage).clickTrash();
        }
        
        [When(@"I click on ListView")]
        public void WhenIClickOnListView()
        {
            ((AccountOperationPage)PropertyCollection.CurrentPage).clickList();
        }
        
        [When(@"I click on GridView")]
        public void WhenIClickOnGridView()
        {
            ((AccountOperationPage)PropertyCollection.CurrentPage).clickGrid();
        }
        
        [When(@"I click on SignOut")]
        public void WhenIClickOnSignOut()
        {
            ((AccountOperationPage)PropertyCollection.CurrentPage).ClickLogout();
        }
        
        [Then(@"Notes should display")]
        public void ThenNotesShouldDisplay()
        {
            Console.WriteLine("note displayed");
        }
        
        [Then(@"Remainders should display")]
        public void ThenRemaindersShouldDisplay()
        {
            Console.WriteLine("remainder displayed");
        }
        
        [Then(@"Archive should display")]
        public void ThenArchiveShouldDisplay()
        {
            Console.WriteLine("archive displayed");
        }
        
        [Then(@"Trash should display")]
        public void ThenTrashShouldDisplay()
        {
            Console.WriteLine("trash displayed");
        }
        
        [Then(@"The notes should display in list")]
        public void ThenTheNotesShouldDisplayInList()
        {
            Console.WriteLine("listView displayed");
        }
        
        [Then(@"The notes should display in Grid")]
        public void ThenTheNotesShouldDisplayInGrid()
        {
            Console.WriteLine("gridView displayed");
        }
        
        [Then(@"I should log out")]
        public void ThenIShouldLogOut()
        {
            Console.WriteLine("logged out");
        }
    }
}
