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

        public static void SwitchToTab(IWebDriver driver, string tabTitle)
        {
            bool tabSwitched = false;



            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);



                if (driver.Title == tabTitle)
                {
                    tabSwitched = true;
                    break;
                }
            }


            if (!tabSwitched)
            {
                throw new ArgumentException(string.Format("[SwitchToTab]: Unable to find tab with name: '{0}'. Actual: '{1}'", tabTitle, driver.Title));
            }
        }

        public static void CloseTab(IWebDriver driver, string tabTitle)
        {
            int windowHandles = driver.WindowHandles.Count();

            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);



                if (driver.Title == tabTitle)
                {
                    driver.Close();
                    break;
                }
            }

            if (driver.WindowHandles.Count() != windowHandles - 1)
            {
                throw new ArgumentException(string.Format("[CloseTab]: Tab '{0}' has not been closed. Actual: '{1}'", tabTitle, driver.Title));
            }
        }

        public static void CloseCurrentTab(IWebDriver driver)
        {
            driver.Close();
        }
    }
}
