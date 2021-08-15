using Ivar.Automation.Tests.Selenium.Grid.TestBase;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivar.Automation.Tests.Selenium.Grid.BrowserHooks
{
    public class Hooks2 : Base2
    {
        [Obsolete]
        public Hooks2()
        {
            capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            //driver = new ChromeDriver();
            driver2 = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);
        }

        [OneTimeSetUp]
        [Obsolete]
        public void openUrl()
        {

            driver2.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/");

        }

        [OneTimeTearDown]
        public void closeInstances()
        {

            
        }
    }
}
