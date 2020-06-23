using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Core;
using TestFrameworkAW.TestFunctions;

namespace TestFrameworkAW.PageObjects
{
    class MainPagePO
    {
        public static string Url
        {
            get
            {
                return TestEnvironment.Url + "/index.html";
            }
        }
        private readonly string _validationElementXPath = "contact-us";
        private readonly IWebDriver _driver = null;

        public MainPagePO(IWebDriver driver)
        {
            _driver = driver;
            WaitTestFunctions.WaitForUrl(_driver, Url);
            PageFactory.InitElements(_driver, this);
            WaitTestFunctions.WaitForElementToBecomeVisible(_driver, By.Id(_validationElementXPath));
        }

        public void GoToLoginPortal()
        {
            WaitTestFunctions.WaitForUrl(_driver, Url);
            WebElementFunctions.ClickOnButton(LoginPortalLink);
        }

        [FindsBy(How = How.Id, Using = "login-portal")]
        public IWebElement LoginPortalLink { get; set; }

    }
}
