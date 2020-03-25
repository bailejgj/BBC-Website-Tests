
using NUnit.Framework;
using SeleniumPOM.lib;

namespace SeleniumPOM.tests
{
    [TestFixture]
    public class BbcLoginTests
    {
        // Instantiate the page objects, include all functionality for the web pages
        // will see that later
        public BbcWebsite BbcWebsite = new BbcWebsite("chrome");

        [Test]
        public void WhenAnInvalidPasswordIsEntered_AnErrorMessageIsDisplayed()
        {
            // go to the BBC home page
            BbcWebsite.bbcHomePage.VisitHomePage();
            // click sign in link
            BbcWebsite.bbcHomePage.ClickSignInLink();

            //TEST FOR NO USERNAME ENTERED
            // enter a username
            BbcWebsite.bbcLoginPage.InputUserName("");
            // enter a password
            BbcWebsite.bbcLoginPage.InputPass("Password1");
            // click the signin button
            BbcWebsite.bbcLoginPage.SubmitLogin();
            // check the error is correct
            Assert.AreEqual(BbcWebsite.bbcLoginPage.UserErrorMsgRead(), "Something's missing. Please check and try again.");



            //TEST FOR NONEXISTENT PASSWORD
            // enter a username
            BbcWebsite.bbcLoginPage.InputUserName("Spartan");
            // enter a password
            BbcWebsite.bbcLoginPage.InputPass("Password1");
            // click the signin button
            BbcWebsite.bbcLoginPage.SubmitLogin();
            // check the error is correct
            Assert.AreEqual(BbcWebsite.bbcLoginPage.PassErrorMsgRead(), "Sorry, that password isn't valid. Make sure it's hard to guess.");

            //TEST FOR ONLY LETTERS PASS
            BbcWebsite.bbcLoginPage.InputUserName("Spartan");
            // enter a password
            BbcWebsite.bbcLoginPage.InputPass("Password");
            // click the signin button
            BbcWebsite.bbcLoginPage.SubmitLogin();
            // check the error is correct
            Assert.AreEqual(BbcWebsite.bbcLoginPage.PassErrorMsgRead(), "Sorry, that password isn't valid. Please include something that isn't a letter.");

            //TEST FOR NO PASSWORD
            BbcWebsite.bbcLoginPage.InputUserName("Spartan");
            // enter a password
            BbcWebsite.bbcLoginPage.InputPass("");
            // click the signin button
            BbcWebsite.bbcLoginPage.SubmitLogin();
            // check the error is correct
            Assert.AreEqual(BbcWebsite.bbcLoginPage.PassErrorMsgRead(), "Something's missing. Please check and try again.");

            //TEST FOR OPENING THE NEWS PAGE ON HOMEPAGE
            // go to the BBC home page
            BbcWebsite.bbcHomePage.VisitHomePage();
            // click sign in link
            BbcWebsite.bbcHomePage.ClickSignInLink();
        }
        [TearDown]
        public void CleanUp()
        {
            BbcWebsite.seleniumDriver.Quit();
        }

        //[Test]
        //public void AccessNewsPage()
        //{
        //    // go to the BBC home page
        //    BbcWebsite.bbcHomePage.VisitHomePage();
        //    // click sign in link
        //    BbcWebsite.bbcHomePage.ClickNewsLink();

        //}
    }
}
