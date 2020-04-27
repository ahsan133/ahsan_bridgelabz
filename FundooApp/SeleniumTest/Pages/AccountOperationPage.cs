using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest.Pages
{
    class AccountOperationPage : BasePage
    {
        public AccountOperationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "note")]
        private IWebElement note;

        [FindsBy(How = How.Id, Using = "remainder1")]
        private IWebElement remainder;

        [FindsBy(How = How.Id, Using = "archive1")]
        private IWebElement archive;

        [FindsBy(How = How.Id, Using = "trash")]
        private IWebElement trash;

        [FindsBy(How = How.Id, Using = "list")]
        private IWebElement list;

        [FindsBy(How = How.Id, Using = "grid")]
        private IWebElement grid;

        [FindsBy(How = How.Id, Using = "ProfilePicture")]
        private IWebElement image;

        [FindsBy(How = How.Id, Using = "logout")]
        private IWebElement logOut;

        public void clickNote()
        {
            System.Threading.Thread.Sleep(2000);
            note.Click();
        }

        public void clickRemainder()
        {
            System.Threading.Thread.Sleep(2000);
            remainder.Click();
        }

        public void clickArchive()
        {
            System.Threading.Thread.Sleep(2000);
            archive.Click();
        }

        public void clickTrash()
        {
            System.Threading.Thread.Sleep(2000);
            trash.Click();
        }

        public void clickList()
        {
            System.Threading.Thread.Sleep(2000);
            list.Click();
        }

        public void clickGrid()
        {
            System.Threading.Thread.Sleep(2000);
            grid.Click();
        }

        public void ClickLogout()
        {
            System.Threading.Thread.Sleep(2000);
            image.Click();
            logOut.Click();
            System.Threading.Thread.Sleep(6000);
        }
    }
}
