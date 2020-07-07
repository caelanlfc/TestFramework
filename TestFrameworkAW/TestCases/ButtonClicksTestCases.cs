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
    class ButtonClicksTestCases
    {
        private readonly IWebDriver Driver;
        public ButtonClicksTestCases(IWebDriver driver)
        {
            Driver = driver;
        }
        public void ButtonWebElementClick()
        {
            CommonFunctions.GoToUrl(Driver, MainPagePO.Url);
            MainPagePO mainPagePO = new MainPagePO(Driver);
            mainPagePO.GoToButtonClicks();
            CommonFunctions.SwitchToTab(Driver, "WebDriver | Button Clicks");
            ButtonClicksPO buttonClicksPO = new ButtonClicksPO(Driver);
            buttonClicksPO.AssertsAllElementsDisplayed();
            buttonClicksPO.OpenWebElementClick();
            buttonClicksPO.WebElementClick();
        }

        public void ButtonJavaScriptClick()
        {
            CommonFunctions.GoToUrl(Driver, MainPagePO.Url);
            MainPagePO mainPagePO = new MainPagePO(Driver);
            mainPagePO.GoToButtonClicks();
            CommonFunctions.SwitchToTab(Driver, "WebDriver | Button Clicks");
            ButtonClicksPO buttonClicksPO = new ButtonClicksPO(Driver);
            buttonClicksPO.AssertsAllElementsDisplayed();
            buttonClicksPO.OpenJavaScriptClick();
            buttonClicksPO.JavaScriptClick();
        }

        public void ButtonActionMoveAndClick()
        {
            CommonFunctions.GoToUrl(Driver, MainPagePO.Url);
            MainPagePO mainPagePO = new MainPagePO(Driver);
            mainPagePO.GoToButtonClicks();
            CommonFunctions.SwitchToTab(Driver, "WebDriver | Button Clicks");
            ButtonClicksPO buttonClicksPO = new ButtonClicksPO(Driver);
            buttonClicksPO.AssertsAllElementsDisplayed();
            buttonClicksPO.OpenActionAndMoveClick();
            buttonClicksPO.ActionMoveAndClick();
        }

    }
}
