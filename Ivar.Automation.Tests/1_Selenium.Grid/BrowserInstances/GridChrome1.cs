using Ivar.Automation.Tests.Selenium.Grid.BrowserHooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivar.Automation.Tests.Selenium.Grid.BrowserInstances
{
    [TestFixture]
    [Parallelizable]
    [Obsolete]
    public class GridChrome1 : Hooks2
    {
        [Test]
        public void GoogleInstance1()
        {
            //driver1.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/");
            driver2.FindElement(By.XPath("//input[@name='userName']")).SendKeys("ravitejayendamuri@gmail.com");
            driver2.FindElement(By.XPath("//input[@name='password']")).SendKeys("Admin@123");
            driver2.FindElement(By.XPath("//input[@name='submit']")).Click();


        }

        [Test]
        public void register()
        {
            driver2.FindElement(By.XPath("//*[text()='REGISTER']")).Click();
        }
    }
}
