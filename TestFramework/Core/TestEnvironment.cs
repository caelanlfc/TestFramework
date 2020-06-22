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

    public static class TestEnvironment // All variables which will be used like login, password, envrionment settings
    {
        public static string Login { get; private set; } = String.Empty;
        public static string Password { get; private set; } = String.Empty;
        public static string Url { get; private set; } = String.Empty;

        public static void Initialize()
        {
            Login = Settings.Default.Login;
            Password = Settings.Default.Password;
            Url = Settings.Default.Url;
        }
    }
}
