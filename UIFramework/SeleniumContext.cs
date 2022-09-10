using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace UIFramework
{
    /// <summary>
    /// Selenium context.
    /// </summary>
    public class SeleniumContext
    {
        /// <summary>
        /// Create instance of SeleniumContext.
        /// </summary>
        /// <param name="browser"></param>
        public SeleniumContext(string browser)
        {
            WebDriver = GetDriver(browser);
        }

        /// <summary>
        /// Gets or sets WebDriver
        /// </summary>
        public IWebDriver WebDriver { get; private set; }

        /// <summary>
        /// Get driver.
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        IWebDriver GetDriver(string driver)
        {
            switch (driver)
            {
                case "Chrome":

                    var options = new ChromeOptions();

                    options.AddArgument("--start-maximized");
                    options.AddArgument("--incognito");
                    options.AddArgument("--disable-infobars");
                    options.AddArgument("--test-type");

                    IWebDriver chromeDriver = new ChromeDriver(options);
                    chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                    chromeDriver.Manage().Cookies.DeleteAllCookies();

                    return chromeDriver;

                case "Firefox":
                    var profile = new FirefoxOptions
                    {
                        AcceptInsecureCertificates = true
                    };
                    IWebDriver firefox = new FirefoxDriver(profile);
                    return firefox;

                default:
                    throw new Exception("Driver not found");
            }
        }
    }
}