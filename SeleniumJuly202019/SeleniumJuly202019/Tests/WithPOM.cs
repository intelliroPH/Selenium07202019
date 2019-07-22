using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumJuly202019.Lib;
using SeleniumJuly202019.Pages;


namespace SeleniumJuly202019
{
    [TestClass]
    public class WithPOM
    {

        Methods _test;
        Homepage _home;
        Dashboard _dash;

        [TestInitialize]
        public void Setup()
        {
            _test = new Methods();
            _home = new Homepage(_test);
            _dash = new Dashboard(_test);

        }

        [TestMethod]
        public void RegisterNewUser()
        {
            _test.InitializeBrowser();
            _home.RegisterUser();
            _dash.LogoutUser();
        }

        [TestMethod]
        public void LoginLogout()
        {
            _test.InitializeBrowser();
            _home.Login();
            _dash.LogoutUser();

        }

        [TestCleanup]
        public void TearDown()
        {
            IWebDriver browser = _test.browser;
            browser.Quit();
        }
    }
}
