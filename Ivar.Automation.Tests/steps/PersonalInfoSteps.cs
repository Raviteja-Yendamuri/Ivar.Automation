using Ivar.Automation.Tests.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Ivar.Automation.Tests.GenericHooks;
using OpenQA.Selenium;

namespace Ivar.Automation.Tests
{
    [Binding]
    public class PersonalInfoSteps
    {

        private IWebDriver _driver;
        public PersonalInfoSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"the user is on Personal Information page")]
        public void GivenTheUserIsOnPersonalInformationPage()
        {
            _driver.Manage().Window.Maximize();
        }

        [When(@"the user enters Personal Information details")]
        [Obsolete]
        public void WhenTheUserEntersPersonalInformationDetails()
        {
            PersonlInformation pi = new PersonlInformation(_driver);
            pi.WritePersonalInformation("Raviteja", "Yendamuri", "yravi1994@yahoo.com");
        }

        [Then(@"the data is displayed")]
        public void ThenTheDataIsDisplayed()
        {
          
        }




    }
}
