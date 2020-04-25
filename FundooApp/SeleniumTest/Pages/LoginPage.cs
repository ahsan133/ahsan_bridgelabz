using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest.Pages
{
    class LoginPage : BasePage
    {
        private IWebDriver driver1;

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver1 = driver;
        }

        [FindsBy(How = How.Id, Using = "mat-input-0")]
        private IWebElement userEmail;

        [FindsBy(How = How.Id, Using = "mat-input-1")]
        private IWebElement userPassword;

        [FindsBy(How = How.Id, Using = "btn")]
        private IWebElement clickLogin;

        public void Login(string email, string password)
        {
            userEmail.SendKeys(email);
            userPassword.SendKeys(password);
        }

        public AddNotePage ClickBtn()
        {
            clickLogin.Click();
            return new AddNotePage(driver1);
        }

    }
}
