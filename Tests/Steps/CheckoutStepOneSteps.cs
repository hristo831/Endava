using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIFramework.Models;
using UIFramework.Pages.CheckoutStepOnePage;

namespace UITests.Steps
{
    [Binding]
    public sealed class CheckoutStepOneSteps
    {
        private readonly CheckoutStepOnePage _checkoutStepOnePage;

        public CheckoutStepOneSteps(CheckoutStepOnePage checkoutStepOnePage)
        {
            _checkoutStepOnePage = checkoutStepOnePage;
        }

        [Given(@"Fill my information")]
        [When(@"Fill my information")]
        public void WhenFillMyInformation(Table myInformation)
        {
            var myInfo = myInformation.CreateInstance<MyInfo>();
            _checkoutStepOnePage.FillMyInformation(myInfo);
        }

        [Given(@"Click Contunue")]
        [When(@"Click Contunue")]
        public void WhenClickContunue()
        {
            _checkoutStepOnePage.ClickContinue();
        }
    }
}
