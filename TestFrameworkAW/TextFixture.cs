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


    }
}
