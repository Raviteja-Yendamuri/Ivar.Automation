using Ivar.Automation.Tests.Selenium.Parallel.TestBase;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivar.Automation.Tests.Selenium.Parallel.BrowserHooks
{
    public class Hooks1 : Base1
    {
        [Obsolete]
        public Hooks1()
        {
            /*

           cap = new DesiredCapabilities();
           cap.SetCapability(CapabilityType.BrowserName, "chrome");
           cap.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
           //driver = new ChromeDriver();
           driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);

           */

            driver1 = new ChromeDriver();
        }

        [OneTimeSetUp]
        [Obsolete]
        public void openUrl()
        {

            driver1.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/");

        }

        [OneTimeTearDown]
        public void closeInstances()
        {

            
        }
    }
}
