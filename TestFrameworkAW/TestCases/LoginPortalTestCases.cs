using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFrameworkAW.PageObjects;
using TestFrameworkAW.TestFunctions;

namespace TestFrameworkAW.TestCases
{
    class LoginPortalTestCases
    {
        private readonly IWebDriver Driver;

        public LoginPortalTestCases(IWebDriver driver)
        {
            Driver = driver;
        }

        public void Login()
        {
            CommonFunctions.GoToUrl(Driver, MainPagePO.Url);
            MainPagePO mainPagePO = new MainPagePO(Driver);
            mainPagePO.GoToLoginPortal();
            LoginPortalPO loginPortalPO = new LoginPortalPO(Driver);
            loginPortalPO.AssertsAllElementsDisplayed();
            loginPortalPO.EnterCredentialsAndPressLogin();
            WebElementFunctions.PressEnterButton(Driver);

            WaitTestFunctions.WaitSeconds(5);
        }
    }
}
