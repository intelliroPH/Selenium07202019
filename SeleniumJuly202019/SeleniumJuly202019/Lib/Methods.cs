using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumJuly202019.Lib
{
    public class Methods
    {
        public IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
        public WebDriverWait wait;
        public int wait_seconds = 120;

        public string url = "http://automationpractice.com";

        //chromeoptions
        public static ChromeOptions ChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            options.AddArgument("--start-maximized");
            options.AddArgument("test-type");
            options.AddArguments("--disable-web-security");
            options.AddArguments("--allow-running-insecure-content");
            options.AddArguments("--disable-extensions");
            return options;
        }
        //Open browser
        public void InitializeBrowser()
        {
            browser.Navigate().GoToUrl(url);
        }

        //Wait for element
        //public void WaitForElement(By element)
        //{
        //   IWebElement x = wait.Until(ExpectedConditions.ElementIsVisible(element));
        //}
    }
}
