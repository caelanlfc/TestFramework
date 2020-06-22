using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkAW.TestFunctions
{
    class WaitTestFunctions
    {
        public static WebDriverWait Wait { get; private set; }
        public static void WaitForElementToBecomeVisible(IWebDriver driver, By by)
        {
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
        public static void WaitSeconds(double seconds)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

        public static void WaitMiliSeconds(double miliSeconds)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(miliSeconds));
        }

        public static void WaitForUrl(IWebDriver driver, string expectedUrl)
        {
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(expectedUrl));
        }
    }
}
