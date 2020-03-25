using OpenQA.Selenium;
using SeleniumPOM.lib.pages;
using SeleniumPOM.lib.driver_config;

namespace SeleniumPOM.lib
{
    // service object for all website pages
    public class BbcWebsite
    {
        // accessible read only page objects
        public readonly BbcHomePage bbcHomePage;
        public readonly BbcLoginPage bbcLoginPage;
        public readonly IWebDriver seleniumDriver;

        // Constructor for driver and config for the service
        public BbcWebsite(string drivername, int pageLoadWaitInSecs = 10, int implicitWaitTimeInSecs = 10)
        {
            // Instantiation of driver
            seleniumDriver = new SeleniumDriverConfig(drivername, pageLoadWaitInSecs, implicitWaitTimeInSecs).Driver;

            // Instantiation of page objects with the selenium driver
            bbcHomePage = new BbcHomePage(seleniumDriver);
            bbcLoginPage = new BbcLoginPage(seleniumDriver);
        }
    }
}
