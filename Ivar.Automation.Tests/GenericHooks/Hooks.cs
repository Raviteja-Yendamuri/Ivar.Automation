using BoDi;
using Ivar.Automation.Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Ivar.Automation.Tests.GenericHooks
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        [Obsolete]
        private DesiredCapabilities cap;

        [Obsolete]
        public Hooks(IObjectContainer objectContainer)
        {

            

             cap = new DesiredCapabilities();
             cap.SetCapability(CapabilityType.BrowserName, "chrome");
             cap.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
             //driver = new ChromeDriver();
             

             
            _objectContainer = objectContainer;


        }

        

        [BeforeScenario]
        [Obsolete]
        public void BeforeTestRun()
        {
            // _driver = new ChromeDriver();
            _driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);

            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            LoginPage lp = new LoginPage(_driver);
            lp.LoginToApplication("ravitejayendamuri@gmail.com", "Admin@123");
        }

        [AfterScenario]
        public void AfterTestRun()
        {
            _driver.Quit();
        }
    }
}
