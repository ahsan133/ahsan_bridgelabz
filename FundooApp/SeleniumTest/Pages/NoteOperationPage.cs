using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest.Pages
{
    class NoteOperationPage : BasePage
    {
        public NoteOperationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "remainder")]
        private IWebElement addRemainder;

        [FindsBy(How = How.Id, Using = "8pm")]
        private IWebElement remainder;

        [FindsBy(How = How.Id, Using = "collab")]
        private IWebElement addCollaborator;

        [FindsBy(How = How.Id, Using = "mat-input-2")]
        private IWebElement collaborator;

        [FindsBy(How = How.Id, Using = "btn")]
        private IWebElement saveCollab;

        [FindsBy(How = How.Id, Using = "color")]
        private IWebElement addColor;

        [FindsBy(How = How.Id, Using = "col(i)")]
        private IWebElement color;

        [FindsBy(How = How.Id, Using = "more")]
        private IWebElement more;

        [FindsBy(How = How.Id, Using = "label")]
        private IWebElement addLabel;

        [FindsBy(How = How.Id, Using = "labelInput")]
        private IWebElement label;

        [FindsBy(How = How.Id, Using = "labelBtn")]
        private IWebElement saveLabel;

        [FindsBy(How = How.Id, Using = "archive")]
        private IWebElement addArchive;

        [FindsBy(How = How.Id, Using = "image")]
        private IWebElement addImage;

        [FindsBy(How = How.Id, Using = "uploadImage")]
        private IWebElement imageUpload;

        [FindsBy(How = How.Id, Using = "open")]
        private IWebElement ChooseImage;

        public void AddImage()
        {
            System.Threading.Thread.Sleep(2000);
            addImage.Click();
        }

        public void ImageUpload()
        {
            ChooseImage.SendKeys(@"C:\Users\HP\Desktop\example.webp");
            //System.Threading.Thread.Sleep(5000);
            //AutoItX3 auto = new AutoItX3();
            //auto.WinActivate("Open");

            System.Threading.Thread.Sleep(5000);
            //auto.Send(@"C:\Users\HP\Desktop\example.webp");
            //System.Threading.Thread.Sleep(9000);
            //auto.Send("{ENTER}");
            imageUpload.Click();
            System.Threading.Thread.Sleep(9000);
        }

        public void AddRemainder()
        {
            addRemainder.Click();
            remainder.Click();
        }

        public void AddCollaborator(string collabs)
        {
            addCollaborator.Click();
            System.Threading.Thread.Sleep(2000);
            collaborator.SendKeys(collabs);   
        }

        public void ClickSave()
        {
            saveCollab.Click();
        }

        public void AddLabelClick()
        {
            more.Click();
            addLabel.Click();
            System.Threading.Thread.Sleep(2000);
        }

        public void AddLabel(string labelIn)
        {
            label.SendKeys(labelIn);
            saveLabel.Click();
        }

        public void AddArchive()
        {
            addArchive.Click();
        }

        public void ChangeColor()
        {
            addColor.Click();
            color.Click();
        }
    }
}
