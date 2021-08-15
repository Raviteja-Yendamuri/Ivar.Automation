using Ivar.Automation.Tests.BrowserActions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ivar.Automation.Tests.Pages
{
    public class ContactUsPage
    {
        public IWebDriver driver;
        [Obsolete]
        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//a[@title='Contact Us']")]
        public IWebElement Contact { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='id_contact']")]
        public IWebElement Subject { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@id='message']")]
        public IWebElement Message { get; set; }

        public void CurrentPageTitle()
        {
            Assert.IsTrue(driver.Title.Contains("My account"));
        }

        public void ContactInfo(string SubjectName, string messg)
        {
            BrowserSetMethods.ClickElement(Contact);
            Thread.Sleep(2000);
            Subject.SelectDropDown(SubjectName);
            Thread.Sleep(2000);
            BrowserSetMethods.ClickElement(Message);
            Thread.Sleep(2000);
            BrowserSetMethods.EnterText(Message, messg);
        }

    }
}
