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
    public class LoginPage
    {
        public IWebDriver driver;
        [Obsolete]
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Sign in']")]
        public IWebElement SignIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
        public IWebElement PassWord { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SubmitLogin']")]
        public IWebElement Submit { get; set; }

        [Obsolete]
        public void LoginToApplication(string username, string password)
        {
            /* SignIn.Click();
             UserName.SendKeys(username);
             PassWord.SendKeys(password);
             Submit.Click();*/

            /*BrowserSetMethods.ClickElement(SignIn);
            BrowserSetMethods.EnterText(UserName, username);
            BrowserSetMethods.EnterText(PassWord, password);
            BrowserSetMethods.ClickElement(Submit);*/

            SignIn.ClickElement();
            UserName.EnterText(username);
            PassWord.EnterText(password);
            Submit.ClickElement();

           
        }




    }


}
