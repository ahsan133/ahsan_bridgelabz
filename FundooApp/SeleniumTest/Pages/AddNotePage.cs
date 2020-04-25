using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest.Pages
{
    class AddNotePage : BasePage
    {
        IWebDriver driver2;

        public AddNotePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver2 = driver;
        }

        [FindsBy(How = How.Id, Using = "title")]
        private IWebElement enterTitle;

        [FindsBy(How = How.Id, Using = "description")]
        private IWebElement enterDescription;

        [FindsBy(How = How.Id, Using = "saveBtn")]
        private IWebElement ClickSave;

        [FindsBy(How = How.Id, Using = "takeNotes")]
        private IWebElement note;

        public void IsLoggedIn()
        {
            System.Threading.Thread.Sleep(8000);
            if (note.Displayed == true)
            {
                Console.WriteLine("logged in");
            }
            else
            {
                Console.WriteLine("not logged in");
                throw new NoSuchElementException();
            }
        }

        public void ClickOnNote()
        {
            note.Click();
        }

        public NoteOperationPage GiveValues(string title, string description)
        {
            enterTitle.SendKeys(title);
            enterDescription.SendKeys(description);
            ClickSave.Click();
            return new NoteOperationPage(driver2);
        }

    }
}
