using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkAW.TestFunctions
{
    class CommonAssertions
    {
        public static bool AssertCurrentUrl(IWebDriver driver, string expectedUrl)
        {
            string driverUrl = driver.Url;
            bool isEqual = false;

            if (driverUrl == expectedUrl)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }

            return isEqual;
        }

        public static void AssertElementIsDisplayed(IWebElement element)
        {
            Assert.True(element.Displayed);
        }
    }
}
