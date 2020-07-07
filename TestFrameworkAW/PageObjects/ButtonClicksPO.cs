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
    class ButtonClicksPO
    {
        public static string ButtonClicksUrl
        {
            get
            {
                return TestEnvironment.Url + "/Click-Buttons/index.html";
            }
        }

        private readonly string _validationElementID = "/html/body/div/div[2]/div/div/div[1]/div/h2";
        private readonly IWebDriver _driver = null;

        public ButtonClicksPO(IWebDriver driver)
        {
            _driver = driver;
            WaitTestFunctions.WaitForUrl(_driver, ButtonClicksUrl);
            PageFactory.InitElements(_driver, this);
            WaitTestFunctions.WaitForElementToBecomeVisible(_driver, By.XPath(_validationElementID));
        }

        public void AssertsAllElementsDisplayed()
        {
            CommonAssertions.AssertElementIsDisplayed(LetsGetClickingLabel);
            CommonAssertions.AssertElementIsDisplayed(WebElementClickLabel);
            CommonAssertions.AssertElementIsDisplayed(JavaScriptClickLabel);
            CommonAssertions.AssertElementIsDisplayed(ActionMoveAndClickLabel);
            CommonAssertions.AssertElementIsDisplayed(ClickMeXPathButton);
            CommonAssertions.AssertElementIsDisplayed(ClickMeCssButton);
            CommonAssertions.AssertElementIsDisplayed(ClickMeIdButton);
        }

        public void OpenWebElementClick()
        {
            WebElementFunctions.ClickOnButton(ClickMeXPathButton);
        }

        public void OpenJavaScriptClick()
        {
            WebElementFunctions.ClickOnButton(ClickMeCssButton);
        }
        public void OpenActionAndMoveClick()
        {
            WebElementFunctions.ClickOnButton(ClickMeIdButton);
        }

        public void WebElementClick()
        {
            CommonFunctions.WindowDisplayedAndClose(_driver, Window, "×\r\nCongratulations!", "Well done for successfully using the click() method!", "Close");
        }

        public void JavaScriptClick()
        {
            CommonFunctions.WindowDisplayedAndClose(_driver, Window, "It’s that Easy!! Well I think it is.....", "We can use JavaScript code if all else fails! Remember always try to use the WebDriver Library method(s) first such as WebElement.click(). (The Selenium development team have spent allot of time developing WebDriver functions etc).", "Close");
        }

        public void ActionMoveAndClick()
        {
            CommonFunctions.WindowDisplayedAndClose(_driver, Window, "Well done! the Action Move & Click can become very useful!", "Advanced user interactions (API) has been developed to enable you to perform more complex interactions such as", "Close");
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div/h1")]
        public IWebElement LetsGetClickingLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div/div[1]/div/h2")]
        public IWebElement WebElementClickLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div/div[2]/div/h2")]
        public IWebElement JavaScriptClickLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div/div[3]/div/h2")]
        public IWebElement ActionMoveAndClickLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div/div[1]/div/div[2]/span/p")]
        public IWebElement ClickMeXPathButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#button2")]
        public IWebElement ClickMeCssButton { get; set; }

        [FindsBy(How = How.Id, Using = "button3")]
        public IWebElement ClickMeIdButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[4]/div/div")]
        public IWebElement Window { get; set; }

    }

}
