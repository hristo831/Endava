using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UIFramework.Pages.LoginPage
{
    /// <summary>
    /// Login page map.
    /// </summary>
    public partial class LoginPage
    {
        [FindsBy(How = How.CssSelector, Using = "[data-test='username']")]
        private readonly IWebElement _userNameField;

        [FindsBy(How = How.CssSelector, Using = "[data-test='password']")]
        private readonly IWebElement _passwordField;

        [FindsBy(How = How.CssSelector, Using = "[data-test='login-button']")]
        private readonly IWebElement _loginButton;

        [FindsBy(How = How.Id, Using = "login_credentials")]
        private readonly IWebElement _validUsernames;

        [FindsBy(How = How.ClassName, Using = "login_password")]
        private readonly IWebElement _validPasswords;
    }
}
