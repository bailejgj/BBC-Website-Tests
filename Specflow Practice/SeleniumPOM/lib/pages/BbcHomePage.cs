using OpenQA.Selenium;

namespace SeleniumPOM.lib.pages
{
    public class BbcHomePage
    {
        private IWebDriver _driver;
        private string _homePageUrl = AppConfigReader.BaseUrl;
        private IWebElement SignInButton => this._driver.FindElement(By.Id("idcta-link"));
        private IWebElement NewsButton => this._driver.FindElement(By.ClassName("orb-nav-news"));
        public BbcHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitHomePage()
        {
            _driver.Navigate().GoToUrl(_homePageUrl);
        }

        public void ClickSignInLink()
        {
            SignInButton.Click();
        }
        public void ClickNewsLink()
        {
            NewsButton.Click();
        }
    }
}
