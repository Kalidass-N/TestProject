using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public sealed class StepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly IPageInterface _pageInterface;

        public StepDefinition(IPageInterface pageInterface, ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _pageInterface = pageInterface;
        }

        [Given(@"I open facebook")]
        public void GivenIOpenFacebook()
        {
            _pageInterface.LaunchURL("https://www.facebook.com");
        }

        [When(@"I enter invalid (.*) and (.*)")]
        public void WhenIEnterInvalidAnd(string username, string password)
        {
            _pageInterface.EnterUsername(username);
            _pageInterface.EnterPassword(password);
            //_pageInterface.ClickLogin();
        }

        [Then(@"Error (.*) is displayed")]
        public void ThenErrorIsDisplayed(string message)
        {
            Assert.AreEqual(message, _pageInterface.GetErrorMessage(), "Error message is different");
        }

    }
}
