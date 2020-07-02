using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

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
        public static void PressEnterButton(IWebDriver driver)
        {
            Actions button = new Actions(driver);
            button.SendKeys(Keys.Enter);
        }
    }
}
