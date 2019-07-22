using System;
using System.Threading;
using OpenQA.Selenium;
using SeleniumJuly202019.Lib;
namespace SeleniumJuly202019.Pages
{
    public class Dashboard
    {
        private Methods _test;

        public Dashboard(Methods methods)
        {
            _test = methods;
        }

        public By userNavIcon = By.Id("userNavigationLabel");
        public By logutLink = By.ClassName("logout");


        public void LogoutUser()
        {
            IWebDriver browser = _test.browser;
            Thread.Sleep(2000);
            browser.FindElement(logutLink).Click();
            Thread.Sleep(2000);
        }

    }
}
