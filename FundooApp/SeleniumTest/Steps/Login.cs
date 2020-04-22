using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;
//using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest.Steps
{
    [Binding]
    class LoginSteps
    {
        readonly IWebDriver driver = new ChromeDriver();

        [Given(@"I have navigated to login page")]
        public void GivenIHaveNavigatedToLoginPage()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/login");

        }

        [Given(@"I see login page is fully loaded")]
        public void GivenISeeLoginPageIsFullyLoadeded()
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

        [When(@"I type email keyword as")]
        public void WhenITypeEmailKeywordAs(Table table)
        {
            dynamic detail = table.CreateDynamicInstance();
            driver.FindElement(By.Id("mat-input-0")).SendKeys(detail.Keyword);
        }

        [When(@"I type password keyword as")]
        public void WhenITypePasswordKeywordAs(Table table)
        {
            dynamic detail = table.CreateDynamicInstance();
            driver.FindElement(By.Id("mat-input-1")).SendKeys(detail.Keyword);
        }

        [Then(@"the result should be logged in")]
        public void ThenTheResultShouldBeLoggedIn()
        {
            Console.WriteLine("done");
        }

    }
}
