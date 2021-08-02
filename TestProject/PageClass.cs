using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class PageClass : IPageInterface
    {
        private readonly IWebDriver _webDriver;
        private By ErrorMessage => By.CssSelector(".fsl.fwb.fcb");

        public PageClass(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void LaunchURL(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }

        public void EnterUsername(string username)
        {
            _webDriver.FindElement(By.Id("email")).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _webDriver.FindElement(By.Id("pass")).SendKeys(password);
        }

        public void ClickLogin()
        {
            _webDriver.FindElement(By.Name("login")).Click();
        }

        public string GetErrorMessage()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(60)).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(ErrorMessage));
            return _webDriver.FindElement(ErrorMessage).Text;
        }
    }
}
