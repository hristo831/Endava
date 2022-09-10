using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UIFramework.Pages
{
    /// <summary>
    /// Base page.
    /// </summary>
    public abstract class BasePage
    {
        /// <summary>
        /// Initializes a new instance of the BasePage class.
        /// </summary>
        /// <param name="driver"></param>
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        /// <summary>
        /// Gets or sets IWebDriver.
        /// </summary>
        public IWebDriver Driver { get; set; }
    }
}
