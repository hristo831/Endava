using TechTalk.SpecFlow;
using UIFramework.Pages.LoginPage;

namespace UITests.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private readonly LoginPage _loginPage;
        public LoginSteps(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        [Given(@"Navigate to Login page")]
        public void GivenNavigateToLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [Given(@"Login with valid username and password")]
        [When(@"Login with valid username and password")]
        public void WhenLoginWithValidUsernameAndPassword()
        {
            _loginPage.LoginWithValidUsernameAndPassword();
        }

        [When(@"Logout from the system")]
        public void WhenLogoutFromTheSystem()
        {
            _loginPage.Logout();
        }


        [Then(@"I am redirected to the Login page with url ""([^""]*)""")]
        [Then(@"I am redirected to the Checkout Complete page with url ""([^""]*)""")]
        [Then(@"I am redirected to the Checkout Step Two page with url ""([^""]*)""")]
        [Then(@"I am redirected to the Checkout Step One page with url ""([^""]*)""")]
        [Then(@"I am redirected to the Cart page with url ""([^""]*)""")]
        [Then(@"I am redirected to the Inventory page with url ""([^""]*)""")]
        public void ThenIAmRedirectedToTheInventoryPageWithUrl(string pageUrl)
        {
            _loginPage.AssertPageUrl(pageUrl);
        }

        [Then(@"Page title is ""([^""]*)""")]
        public void ThenPageTitleIs(string pageTitle)
        {
            _loginPage.AssertPageTitle(pageTitle);
        }
    }
}
