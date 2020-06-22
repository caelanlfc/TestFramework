using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkAW.TestFunctions
{
    class WebElementFunctions
    {
        public static void ClickOnButton(IWebElement element)
        {
            element.Click();
        }
        public static void EnterText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }
    }
}
