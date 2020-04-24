using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "btn")]
        private IWebElement clickLogin;

        public DashboardPage ClickBtn()
        {
            clickLogin.Click();
            return new DashboardPage();
        }

    }
}
