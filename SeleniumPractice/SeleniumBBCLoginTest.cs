using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumPractice
{
    [TestFixture]
    public class SeleniumBBCLoginTest
    {
        [Test]
        public void LoginTest()
        {
            //using polymorphism make a chrome instance of Iwebdriver
            using (IWebDriver driver = new ChromeDriver())
            {
                //maximise the browser to full screen
                driver.Manage().Window.Maximize();
                //Wait if nothing is found (compensate for loading time)
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //navigate to the BBC homepage
                driver.Navigate().GoToUrl("https://www.bbc.co.uk");
                //click login button
                IWebElement LoginButton = driver.FindElement(By.Id("idcta-link"));
                LoginButton.Click();
                //enter a username
                IWebElement UserNameInput = driver.FindElement(By.Id("user-identifier-input"));
                UserNameInput.Click();
                UserNameInput.SendKeys("Username1");
                //enter a password
                IWebElement PassInput = driver.FindElement(By.Id("password-input"));
                PassInput.Click();
                PassInput.SendKeys("Password1");
                //click the signin button
                IWebElement SignIn = driver.FindElement(By.Id("submit-button"));
                SignIn.Click();
                //check the error is correct
                IWebElement ErrorMessage = driver.FindElement(By.Id("form-message-username"));
                Assert.That(ErrorMessage.Text, Is.EqualTo("Sorry, we can’t find an account with that username. If you're over 13, try your email address instead or get help here."));
            }

        }
        [Test]
        public void OnlyNumbersPassTest()
        {
            //using polymorphism make a chrome instance of Iwebdriver
            using (IWebDriver driver = new ChromeDriver())
            {
                //maximise the browser to full screen
                driver.Manage().Window.Maximize();
                //Wait if nothing is found (compensate for loading time)
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //navigate to the BBC homepage
                driver.Navigate().GoToUrl("https://account.bbc.com/signin");
                //enter a username
                IWebElement UserNameInput = driver.FindElement(By.Id("user-identifier-input"));
                UserNameInput.Click();
                UserNameInput.SendKeys("Username1");
                //enter a password
                IWebElement PassInput = driver.FindElement(By.Id("password-input"));
                PassInput.Click();
                PassInput.SendKeys("1235234231");
                //click the signin button
                IWebElement SignIn = driver.FindElement(By.Id("submit-button"));
                SignIn.Click();
                //check the error is correct
                IWebElement ErrorMessage = driver.FindElement(By.Id("form-message-password"));
                Assert.That(ErrorMessage.Text, Is.EqualTo("Sorry, that password isn't valid"));
            }
        }
        [Test]
        public void ShortPassTest()
        {
            //using polymorphism make a chrome instance of Iwebdriver
            using (IWebDriver driver = new ChromeDriver())
            {
                //maximise the browser to full screen
                driver.Manage().Window.Maximize();
                //Wait if nothing is found (compensate for loading time)
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //navigate to the BBC homepage
                driver.Navigate().GoToUrl("https://account.bbc.com/signin");
                //enter a username
                IWebElement UserNameInput = driver.FindElement(By.Id("user-identifier-input"));
                UserNameInput.Click();
                UserNameInput.SendKeys("Username1");
                //enter a password
                IWebElement PassInput = driver.FindElement(By.Id("password-input"));
                PassInput.Click();
                PassInput.SendKeys("a1");
                //click the signin button
                IWebElement SignIn = driver.FindElement(By.Id("submit-button"));
                SignIn.Click();
                //check the error is correct
                IWebElement ErrorMessage = driver.FindElement(By.Id("form-message-password"));
                Assert.That(ErrorMessage.Text, Is.EqualTo("It needs to be eight characters or more."));
            }
        }
    }
}
