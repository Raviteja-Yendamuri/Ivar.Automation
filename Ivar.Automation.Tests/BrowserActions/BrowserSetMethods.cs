using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivar.Automation.Tests.BrowserActions
{
    public static class BrowserSetMethods
    {

        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void ClickElement(this IWebElement element)
        {
            element.Click();
        }

        public static void ClearElement(this IWebElement element)
        {
            element.Clear();
        }

        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }




    }
}
