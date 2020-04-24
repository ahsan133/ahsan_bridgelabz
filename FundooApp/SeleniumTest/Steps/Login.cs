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

        

        [Given(@"I have navigated to Login page")]
        public void GivenIHaveNavigatedToLoginPage()
        {
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

        [When(@"I type email Keyword as")]
        public void WhenITypeEmailKeywordAs(Table table)
        {
            dynamic detail = table.CreateDynamicInstance();
            driver.FindElement(By.Id("mat-input-0")).SendKeys(detail.Keyword);
        }

        [When(@"I type password Keyword as")]
        public void WhenITypePasswordKeywordAs(Table table)
        {
            dynamic detail = table.CreateDynamicInstance();
            driver.FindElement(By.Id("mat-input-1")).SendKeys(detail.Keyword);

            LoginPage page = new LoginPage(driver);

            DashboardPage DPage = page.ClickBtn();
        }

        [Then(@"It should log in")]
        public void ThenItShouldLogIn()
        {
            Console.WriteLine("logged in");
        }
    }
}
