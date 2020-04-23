using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Chrome;


namespace SeleniumTest.Steps
{
    [Binding]
    public class AdminLoginSteps
    {
        readonly IWebDriver driver = new ChromeDriver();

        [Given(@"I have navigated to AdminLogin page")]
        public void GivenIHaveNavigatedToAdminLoginPage()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/login");
            driver.FindElement(By.Id("adminLogin")).Click();
        }
        
        [Given(@"I see AdminLogin page is fully loaded")]
        public void GivenISeeAdminLoginPageIsFullyLoaded()
        {
            if (driver.FindElement(By.Id("mat-input-2")).Displayed == true)
            {
                Console.WriteLine("loaded");
            }
            else
            {
                Console.WriteLine("not loaded");
            }
        }
        
        [When(@"I type email Keyword for admin as")]
        public void WhenITypeEmailKeywordForAdminAs(Table table)
        {
            dynamic detail = table.CreateDynamicInstance();
            driver.FindElement(By.Id("mat-input-2")).SendKeys(detail.Keyword);
        }
        
        [When(@"I type password Keyword for admin as")]
        public void WhenITypePasswordKeywordForAdminAs(Table table)
        {
            dynamic detail = table.CreateDynamicInstance();
            driver.FindElement(By.Id("mat-input-3")).SendKeys(detail.Keyword);
            driver.FindElement(By.Id("btn")).Click();
        }
        
        [Then(@"It should log in as admin")]
        public void ThenItShouldLogInAsAdmin()
        {
            Console.WriteLine("logged in");
        }
    }
}
