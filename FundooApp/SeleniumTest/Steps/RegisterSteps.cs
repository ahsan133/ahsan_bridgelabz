using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTest.Steps
{
    [Binding]
    public class RegisterSteps
    {
        readonly IWebDriver driver = new ChromeDriver();

        [Given(@"I have navigated to Register page")]
        public void GivenIHaveNavigatedToRegisterPage()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/register");
        }

        [Given(@"I see Register page is fully loaded")]
        public void GivenISeeRegisterPageIsFullyLoaded()
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

        [When(@"I type data as")]
        public void WhenITypeDataAs(Table table)
        {
            dynamic detail = table.CreateDynamicInstance();
            driver.FindElement(By.Id("mat-input-0")).SendKeys(detail.FirstName);
            driver.FindElement(By.Id("mat-input-1")).SendKeys(detail.LastName);
            driver.FindElement(By.Id("mat-input-2")).SendKeys(detail.Email);
            driver.FindElement(By.Id("mat-input-3")).SendKeys(detail.Password);
            driver.FindElement(By.Id("btn")).Click();
        }

        [Then(@"It should register")]
        public void ThenItShouldRegister()
        {
            Console.WriteLine("registered");
        }
    }
}
