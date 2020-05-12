using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Pages;

namespace SeleniumTest.Steps
{
    [Binding]
    class LoginSteps
    {
        IWebDriver driver = new ChromeDriver();
        //protected Recorder sr = new Recorder();

        [Given(@"I have navigated to Login page")]
        public void GivenIHaveNavigatedToLoginPage()
        {
           // sr.SetVideoOutputLocation();
            //sr.StartRecording();
            driver.Navigate().GoToUrl("http://localhost:4200/login");
        }

        [Given(@"I see Login page is fully loaded")]
        public void GivenISeeLoginPageIsFullyLoaded()
        {
            if (driver.FindElement(By.Id("mat-input-0")).Displayed == true)
            {
                Console.WriteLine("loaded");
            }
            else
            {
                Console.WriteLine("not loaded");
            }
        }

        [When(@"I type email and password")]
        public void WhenITypeEmailAndPassword(Table table)
        {
            LoginPage page = new LoginPage(driver);

            dynamic detail = table.CreateDynamicInstance();
            page.Login(detail.Email, detail.Password);

        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            LoginPage page = new LoginPage(driver);

            PropertyCollection.CurrentPage = page.ClickBtn();
        }

        [Then(@"It should log in")]
        public void ThenItShouldLogIn()
        {
            AddNotePage NPage = new AddNotePage(driver);
            NPage.IsLoggedIn();
            //sr.StopRecording();
        }
    }
}
