using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumJuly202019
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchGoogle()
        {
            IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
            browser.Navigate().GoToUrl("http://google.com");
            browser.FindElement(By.Name("q")).SendKeys("Mobile Legends" + Keys.Enter);
            browser.Close();
        }

        [TestMethod]
        public void CreateAnAccount()
        {
            IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
            browser.Navigate().GoToUrl("http://automationpractice.com");
            IWebElement signInLink = browser.FindElement(By.ClassName("login"));
            Thread.Sleep(5000);

            Assert.IsTrue(signInLink.Displayed);
            signInLink.Click();

            //Pang Accept
            browser.SwitchTo().Alert().Accept();
            //Pang refresh ng webpage
            browser.Navigate().Refresh();
        }

        [TestMethod]
        public void LoginLogout()
        {
            IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
            browser.Navigate().GoToUrl("https://iomanila-6ff2b.firebaseapp.com/");
            Thread.Sleep(5000);

            //Login
            browser.FindElement(By.Id("emailField")).SendKeys("hanabi@ml.com");
            browser.FindElement(By.Id("passwordField")).SendKeys("123123");
            browser.FindElement(By.ClassName("loginBtn")).Click();
            Thread.Sleep(2000);

            //Welcome Message
            string welcomeMessage = browser.FindElement(By.CssSelector("#Content > p:nth-child(2)")).Text;

            //Assert
            Assert.AreEqual("Logged in successfully, hanabi@ml.com", welcomeMessage, "Result is incorrect");

            //click logout
            browser.FindElement(By.ClassName("logoutBtn")).Click();
            //string contentmessagebox = browser.FindElement to check for content box
            //Assert.AreEqual("", contentmessagebox);
            Thread.Sleep(2000);

            browser.Close();


        }
    }
}
