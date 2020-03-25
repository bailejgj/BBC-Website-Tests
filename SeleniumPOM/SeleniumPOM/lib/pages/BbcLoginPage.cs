using OpenQA.Selenium;

namespace SeleniumPOM.lib.pages
{
    public class BbcLoginPage
    {
        private IWebDriver _driver;
        private string _loginPageUrl = AppConfigReader.SignInPageUrl;
        private IWebElement UserNameField => this._driver.FindElement(By.Id("user-identifier-input"));
        private IWebElement PassField => this._driver.FindElement(By.Id("password-input"));
        private IWebElement SubmitButton => this._driver.FindElement(By.Id("submit-button"));
        private IWebElement UserErrorMsg => this._driver.FindElement(By.Id("form-message-username"));
        private IWebElement PassErrorMsg => this._driver.FindElement(By.Id("form-message-password"));
        public BbcLoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void VisitLoginPage()
        {
            _driver.Navigate().GoToUrl(_loginPageUrl);
        }
        public void InputUserName(string username)
        {
            UserNameField.SendKeys(username);
        }
        public void InputPass(string password)
        {
            PassField.SendKeys(password);
        }
        public void SubmitLogin()
        {
            SubmitButton.Click();
        }
        public string UserErrorMsgRead()
        {
            return UserErrorMsg.Text;
        }
        public string PassErrorMsgRead()
        {
            return PassErrorMsg.Text;
        }
    }
}
