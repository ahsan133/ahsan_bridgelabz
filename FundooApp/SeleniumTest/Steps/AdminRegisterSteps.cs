using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace SeleniumTest.Steps
{
    [Binding]
    public class AdminRegisterSteps
    {
        readonly IWebDriver driver = new ChromeDriver();

        [Given(@"I have navigated to adminRegister page")]
        public void GivenIHaveNavigatedToAdminRegisterPage()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/adminRegister");
        }
        
        [Given(@"I see adminRegister page is fully loaded")]
        public void GivenISeeAdminRegisterPageIsFullyLoaded()
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

        [When(@"I type data for admin as")]
        public void WhenITypeDataForAdminAs(Table table)
        {
            dynamic detail = table.CreateDynamicInstance();
            driver.FindElement(By.Id("mat-input-0")).SendKeys(detail.FirstName);
            driver.FindElement(By.Id("mat-input-1")).SendKeys(detail.LastName);
            driver.FindElement(By.Id("mat-input-2")).SendKeys(detail.Email);
            driver.FindElement(By.Id("mat-input-3")).SendKeys(detail.Password);
            driver.FindElement(By.Id("btn")).Click();
        }

        [Then(@"It should register for admin")]
        public void ThenItShouldRegisterForAdmin()
        {
            Console.WriteLine("registered");
        }
    }
}
