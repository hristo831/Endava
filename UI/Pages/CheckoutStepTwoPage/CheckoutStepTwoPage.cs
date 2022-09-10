using OpenQA.Selenium;

namespace UIFramework.Pages.CheckoutStepTwoPage
{
    /// <summary>
    /// Checkout step two page.
    /// </summary>
    public partial class CheckoutStepTwoPage : BaseOperations
    {
        public CheckoutStepTwoPage(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Click finish button.
        /// </summary>
        public void ClickFinish()
        {
            _finishButton.Click();
        }
    }
}
