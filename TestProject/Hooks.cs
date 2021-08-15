using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public class Hooks
    {
        public readonly IObjectContainer _objectContainer;
        public IWebDriver _webDriver;
        public ScenarioContext context;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            _webDriver = new ChromeDriver(options);
            _webDriver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs(_webDriver);
        }

        [BeforeScenario]
        public void RegisterPage()
        {
            _objectContainer.RegisterTypeAs<PageClass, IPageInterface>();
        }
     
        [AfterScenario]
        public void AfterScenario()
        {
            _webDriver.Quit();
            _objectContainer.Dispose();
        }
    }
}
