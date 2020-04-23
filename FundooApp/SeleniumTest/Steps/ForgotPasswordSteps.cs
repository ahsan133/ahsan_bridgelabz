using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest.Steps
{
    [Binding]
    public class ForgotPasswordSteps
    {
        readonly IWebDriver driver = new ChromeDriver();

        [Given(@"I have navigated to ForgotPassword page")]
        public void GivenIHaveNavigatedToForgotPasswordPage()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/forgot");
        }
        
        [Given(@"I see ForgotPassword page is fully loaded")]
        public void GivenISeeForgotPasswordPageIsFullyLoaded()
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
        
        [When(@"I type email as")]
        public void WhenITypeEmailAs(Table table)
        {
            dynamic detail = table.CreateDynamicInstance();
            driver.FindElement(By.Id("mat-input-0")).SendKeys(detail.Email);
            driver.FindElement(By.Id("btn")).Click();
        }
        
        [Then(@"It should send mail")]
        public void ThenItShouldSendMail()
        {
            Console.WriteLine("mail sent.");
        }
    }
}
