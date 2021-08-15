using Ivar.Automation.Tests.GenericHooks;
using Ivar.Automation.Tests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Ivar.Automation.Tests.steps
{
    [Binding]
    public class ContactUsSteps
    {
        private IWebDriver _driver;
        public ContactUsSteps(IWebDriver driver)
        {
            _driver = driver;
        }
        public static ContactUsPage  cup;
        [Given(@"the user is on home page")]
        [Obsolete]
        public void GivenTheUserIsOnHomePage()
        {
            cup = new ContactUsPage(_driver);
            cup.CurrentPageTitle();
        }

        [When(@"the user clicks on Contact us and enter message")]
        public void WhenTheUserClicksOnContactUsAndEnterMessage()
        {
           
            cup.ContactInfo("Customer service", "Hello Ravi");
        }

        [Then(@"the data should be displayed")]
        public void ThenTheDataShouldBeDisplayed()
        {
           
        }





    }
}
