using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Helpers;

namespace TestFramework.Core
{
    public class TestBase
    {
        public static List<Browsers> BrowsersToRunWith = new List<Browsers> // Creating a list of browsers to run
        {
            Browsers.Chrome,
            Browsers.Firefox,
            Browsers.Edge
        };

        protected IWebDriver Driver { get; private set; }

        protected IWebDriver LaunchProperBrowser(Browsers browser) // method used to launching browsers
        {
            switch (browser)
            {
                case Browsers.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--land=en-GB");
                    Driver = new ChromeDriver(chromeOptions);
                    break;

                case Browsers.Firefox:
                    FirefoxProfile firefoxProfile = new FirefoxProfile();
                    firefoxProfile.SetPreference("intl.accept_languages", "en-GB, en");
                    firefoxProfile.SetPreference("browser.search.countryCode", "GB");
                    FirefoxOptions firefoxOptions = new FirefoxOptions()
                    {
                        Profile = firefoxProfile
                    };

                    Driver = new FirefoxDriver(firefoxOptions);

                    break;

                case Browsers.Edge:
                    EdgeOptions edgeOptions = new EdgeOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.None
                    };

                    Driver = new EdgeDriver(edgeOptions);
                    break;
            }

            Driver.Manage().Window.Maximize();
            return Driver;
        }

        public static IEnumerable<Browsers> GetBrowserToRunWith()
        {
            foreach (var browser in BrowsersToRunWith)
            {
                yield return browser;
            }
        }

        [SetUp]
        public void BaseSetUp()
        {
            TestEnvironment.Initialize();
        }
        [TearDown]
        public void BaseTearDown()
        {
            Driver.Quit();
        }
    }

}
