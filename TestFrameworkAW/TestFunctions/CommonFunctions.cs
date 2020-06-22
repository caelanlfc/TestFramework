using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkAW.TestFunctions
{
    class CommonFunctions
    {
        public static void GoToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            WaitTestFunctions.WaitForUrl(driver, url);
        }
    }
}
