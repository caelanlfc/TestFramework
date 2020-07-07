using TestFrameworkAW.TestCases;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Core;
using TestFramework.Helpers;


namespace TestFrameworkAW
{

    [TestFixture]
    class TextFixture : TestBase
    {
        [Test]
        [Category("LoginPortal")]
        [TestCaseSource(typeof(TestBase), "GetBrowserToRunWith")]

        public void GoToLoginPortal(Browsers browserName)
        {
            LaunchProperBrowser(browserName);
            LoginPortalTestCases loginPortalTestCases = new LoginPortalTestCases(Driver);
            loginPortalTestCases.Login();
        }

        [Test]
        [Category("ButtonClicks")]
        [TestCaseSource(typeof(TestBase), "GetBrowserToRunWith")]
        public void ButtonWebElementClick(Browsers browserName)
        {
            LaunchProperBrowser(browserName);
            ButtonClicksTestCases buttonClicksTestCases = new ButtonClicksTestCases(Driver);
            buttonClicksTestCases.ButtonWebElementClick();
        }

        [Test]
        [Category("ButtonClicks")]
        [TestCaseSource(typeof(TestBase), "GetBrowserToRunWith")]
        public void ButtonJavaScriptClick(Browsers browserName)
        {
            LaunchProperBrowser(browserName);
            ButtonClicksTestCases buttonClicksTestCases = new ButtonClicksTestCases(Driver);
            buttonClicksTestCases.ButtonJavaScriptClick();
        }

        [Test]
        [Category("ButtonClicks")]
        [TestCaseSource(typeof(TestBase), "GetBrowserToRunWith")]
        public void ButtonActionMoveAndClick(Browsers browserName)
        {
            LaunchProperBrowser(browserName);
            ButtonClicksTestCases buttonClicksTestCases = new ButtonClicksTestCases(Driver);
            buttonClicksTestCases.ButtonActionMoveAndClick();
        }

    }
}
