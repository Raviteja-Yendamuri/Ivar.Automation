using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivar.Automation.Tests.Selenium.Parallel.TestBase
{
    public class Base1
    {
        [Obsolete]
      //  public DesiredCapabilities cap { get; set; }
        public IWebDriver driver1 { get; set; }
    }
}
