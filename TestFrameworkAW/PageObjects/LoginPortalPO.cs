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
    class LoginPortalPO
    {
        public static string LoginPortalUrl
        {
            get
            {
                return TestEnvironment.Url + "Login-Portal/index.html";
            }
        }
        private readonly string _validationElementID = "login-button";
        private readonly IWebDriver _driver = null;

        public LoginPortalPO(IWebDriver driver)
        {
            _driver = driver;
            WaitTestFunctions.WaitForUrl(_driver, LoginPortalUrl);
            PageFactory.InitElements(_driver, this);
            WaitTestFunctions.WaitForElementToBecomeVisible(_driver, By.Id(_validationElementID));
        }

    }
}
