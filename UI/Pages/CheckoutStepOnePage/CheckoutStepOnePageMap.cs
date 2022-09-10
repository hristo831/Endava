using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UIFramework.Pages.CheckoutStepOnePage
{
    /// <summary>
    /// Checkout step one page map.
    /// </summary>
    public partial class CheckoutStepOnePage
    {
        [FindsBy(How = How.CssSelector, Using = "[data-test='firstName']")]
        private readonly IWebElement _firstNameField;

        [FindsBy(How = How.CssSelector, Using = "[data-test='lastName']")]
        private readonly IWebElement _lastNameField;

        [FindsBy(How = How.CssSelector, Using = "[data-test='postalCode']")]
        private readonly IWebElement _zipCodeField;

        [FindsBy(How = How.CssSelector, Using = "[data-test='continue']")]
        private readonly IWebElement _continueButton;
    }
}
