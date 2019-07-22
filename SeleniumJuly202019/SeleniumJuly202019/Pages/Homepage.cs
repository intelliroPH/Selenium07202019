using System;
using System.Threading;
using OpenQA.Selenium;
using SeleniumJuly202019.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SeleniumJuly202019.Pages
{
    public class Homepage
    {
        private Methods _test;

        public Homepage(Methods methods)
        {
            _test = methods;
        }

        public By contactLink = By.Id("contact-link");
        public By signinLink = By.ClassName("login");
        public By emailIdRegister = By.Name("email_create");
        public By regBtn = By.Id("SubmitCreate");
        public By womenLink = By.LinkText("Women");
        public By dressesLink = By.LinkText("Dresses");
        public By tshirtsLink = By.LinkText("Tshirts");


        //public string emailAddress = "legitHumanbean@earthlings.com";//SubmitCreate

        public void Login()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(By.ClassName("login")).Click();
            browser.FindElement(By.Name("email")).SendKeys("selenium@07202019.com");
            browser.FindElement(By.Name("passwd")).SendKeys("123123A");
            browser.FindElement(By.Id("SubmitLogin")).Click();

        }

        public void RegisterUser(string emailAdd = "email@emailtest1.com")
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(signinLink).Click();
            Thread.Sleep(2000);
            browser.FindElement(emailIdRegister).SendKeys(emailAdd);
            browser.FindElement(regBtn).Click();
            Thread.Sleep(2000);
        }

        public void ClickContactUs()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(contactLink).Click();
            Thread.Sleep(2000);
        }

        public void ClickWomenLink()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(womenLink).Click();
            Thread.Sleep(2000);
        }
        public void ClickDressesLink()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(dressesLink).Click();
            Thread.Sleep(2000);
        }
        public void ClickTshirtsLink()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(tshirtsLink).Click();
            Thread.Sleep(2000);
        }
    }
}
