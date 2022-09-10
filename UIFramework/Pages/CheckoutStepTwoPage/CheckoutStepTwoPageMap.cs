using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UIFramework.Pages.CheckoutStepTwoPage
{
    /// <summary>
    /// Checkout step two page map.
    /// </summary>
    public partial class CheckoutStepTwoPage
    {
        [FindsBy(How = How.CssSelector, Using = "[data-test='finish']")]
        private readonly IWebElement _finishButton;
    }
}
