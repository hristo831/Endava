using TechTalk.SpecFlow;
using UIFramework.Pages.CheckoutStepTwoPage;

namespace UITests.Steps
{
    [Binding]
    public sealed class CheckoutStepTwoSteps
    {
        private readonly CheckoutStepTwoPage _checkoutStepTwoPage;

        public CheckoutStepTwoSteps(CheckoutStepTwoPage checkoutStepTwoPage)
        {
            _checkoutStepTwoPage = checkoutStepTwoPage;
        }

        [When(@"Click finish")]
        public void WhenClickFinish()
        {
            _checkoutStepTwoPage.ClickFinish(); 
        }

    }
}
