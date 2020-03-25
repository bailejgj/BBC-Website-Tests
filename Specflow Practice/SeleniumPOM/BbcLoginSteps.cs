using System;
using TechTalk.SpecFlow;

namespace SeleniumPOM
{
    [Binding]
    public class BbcLoginSteps
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have enter a valid username of ""Cathy@home\.com”")]
        public void GivenIHaveEnterAValidUsernameOfCathyHome_Com()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a invalid password of “(.*)”")]
        public void GivenIHaveEnteredAInvalidPasswordOf(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the error message “Sorry, that password isn’t valid\. Please include a letter”")]
        public void ThenIShouldSeeTheErrorMessageSorryThatPasswordIsnTValid_PleaseIncludeALetter()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
