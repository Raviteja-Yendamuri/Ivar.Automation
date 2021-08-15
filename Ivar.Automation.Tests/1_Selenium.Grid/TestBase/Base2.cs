using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivar.Automation.Tests.Selenium.Grid.TestBase
{
    public class Base2
    {
        [Obsolete]
        public DesiredCapabilities capabilities { get; set; }
        public IWebDriver driver2 { get; set; }
    }
}
