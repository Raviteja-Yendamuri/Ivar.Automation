using Ivar.Automation.Tests.Selenium.Parallel.BrowserHooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivar.Automation.Tests.Selenium.Parallel.BrowserInstances
{
    [TestFixture]
    [Parallelizable]
    [Obsolete]
    public class Chrome2 : Hooks1
    {
        [Test]
        public void GoogleInstance1()
        {
           // driver1.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/");
            driver1.FindElement(By.XPath("//input[@name='userName']")).SendKeys("ravitejayendamuri@gmail.com");
            driver1.FindElement(By.XPath("//input[@name='password']")).SendKeys("Admin@123");
            driver1.FindElement(By.XPath("//input[@name='submit']")).Click();
        }

        [Test]
        public void support()
        {
            driver1.FindElement(By.XPath("//*[text()='SUPPORT']")).Click();
        }
    }
}
