using Ivar.Automation.Tests.BrowserActions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivar.Automation.Tests.Pages
{
    public class PersonlInformation
    {

        public IWebDriver driver;
        [Obsolete]
        public PersonlInformation(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='My personal information']")]
        public IWebElement MyPersonalInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='firstname']")]
        public IWebElement MyFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='lastname']")]
        public IWebElement MyLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        public IWebElement MyEmailId { get; set; }

        public void WritePersonalInformation(string username, string password, string emailid)
        {
            /* MyPersonalInfo.Click();
             MyFirstName.Clear();
             MyFirstName.SendKeys(username);
             MyLastName.Clear();
             MyLastName.SendKeys(password);
             MyEmailId.Clear();
             MyEmailId.SendKeys(emailid);*/

            BrowserSetMethods.ClickElement(MyPersonalInfo);
            BrowserSetMethods.ClearElement(MyFirstName);
            BrowserSetMethods.EnterText(MyFirstName, username);
            BrowserSetMethods.ClearElement(MyLastName);
            BrowserSetMethods.EnterText(MyLastName, password);
            BrowserSetMethods.ClearElement(MyEmailId);
            BrowserSetMethods.EnterText(MyEmailId, emailid);
           
        }
    }
}
