using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeliniumTesting
{
    class UserTest
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {

        }

       
        [Test]
        public void Register()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/register");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("mda");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("ahsan");
            driver.FindElement(By.Id("mat-input-2")).SendKeys("ahsan@gmail.com");
            driver.FindElement(By.Id("mat-input-3")).SendKeys("ahsan123");
            driver.FindElement(By.Id("btn")).Click();
        }

        [Test]
        public void Login()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/login");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("ahsan@gmail.com");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("ahsan123");
            driver.FindElement(By.Id("btn")).Click();
        }

        [Test]
        public void Forgot()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/forgot");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("ahsan@gmail.com");
            driver.FindElement(By.Id("btn")).Click();
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
