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
                return TestEnvironment.Url + "/Login-Portal/index.html";
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

        public void AssertsAllElementsDisplayed()
        {
            CommonAssertions.AssertElementIsDisplayed(LoginTB);
            CommonAssertions.AssertElementIsDisplayed(PasswordTB);
            CommonAssertions.AssertElementIsDisplayed(LoginButton);
        }

        public void EnterCredentialsAndPressLogin()
        { 
            WebElementFunctions.EnterText(LoginTB, "login");
            WebElementFunctions.EnterText(PasswordTB, "password");
            WebElementFunctions.ClickOnButton(LoginButton);
            WebElementFunctions.PressEnterButton(_driver);
        }

        [FindsBy(How = How.Id, Using = "text")]
        public IWebElement LoginTB { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordTB { get; set; }

        [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement LoginButton { get; set; }
    }
}
