using SeleniumPOM.lib;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SeleniumPOM.BDD
{
    [Binding]
    public class BbcLoginSteps
    {
        private BbcWebsite _bbcWebsite;
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _bbcWebsite = new BbcWebsite("chrome");
            _bbcWebsite.bbcLoginPage.VisitLoginPage();
        }
        [Given(@"I have enter a valid username of ""(.*)""")]
        public void GivenIHaveEnterAValidUsernameOf(string username)
        {
            _bbcWebsite.bbcLoginPage.InputUserName(username);
        }
        
        [Given(@"I have entered a invalid password of ""(.*)""")]
        public void GivenIHaveEnteredAInvalidPasswordOf(string password)
        {
            _bbcWebsite.bbcLoginPage.InputPass(password);
        }
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            _bbcWebsite.bbcLoginPage.SubmitLogin();
        }
        [Then(@"I should see the error message ""(.*)""")]
        public void ThenIShouldSeeTheErrorMessage(string errorMsg)
        {
            Assert.That(_bbcWebsite.bbcLoginPage.PassErrorMsgRead, Is.EqualTo(errorMsg));
        }
        [AfterScenario]
        public void DisposeWebDriver()
        {
            _bbcWebsite.seleniumDriver.Dispose();
        }
    }
}
