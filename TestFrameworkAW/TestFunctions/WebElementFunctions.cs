using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

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

        public static IEnumerable<IWebElement> FindChildElements(IWebDriver driver, IWebElement parentElement, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var elements = wait.Until(drv => parentElement.FindElements(by));
            if(elements.Count > 0)
            {
                return elements;
            }
            else
            {
                return null;
            }    
        }

        public static IWebElement FindChildElement (IWebDriver driver, IWebElement parentElement, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(drv => parentElement.FindElement(by));
            return element;
        }
    }
}
