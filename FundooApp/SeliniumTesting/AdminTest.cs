using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeliniumTesting
{
    class AdminTest
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void AdminRegister()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/adminRegister");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("mda");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("ahsan");
            driver.FindElement(By.Id("mat-input-2")).SendKeys("ahsan@gmail.com");
            driver.FindElement(By.Id("mat-input-3")).SendKeys("ahsan123");
            driver.FindElement(By.Id("btn")).Click();
        }

        [Test]
        public void AdminLogin()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/login");
            driver.FindElement(By.Id("adminLogin")).Click();
            driver.FindElement(By.Id("mat-input-2")).SendKeys("ahsan@gmail.com");
            driver.FindElement(By.Id("mat-input-3")).SendKeys("ahsan123");
            driver.FindElement(By.Id("btn")).Click();
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
