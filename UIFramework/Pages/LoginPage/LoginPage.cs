using OpenQA.Selenium;
using TestConfiguration;

namespace UIFramework.Pages.LoginPage
{
    /// <summary>
    /// Login page.
    /// </summary>
    public partial class LoginPage : BaseOperations
    {
        /// <summary>
        /// Initializes a new instance of the LoginPage class.
        /// </summary>
        /// <param name="driver"></param>
        public LoginPage(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Navigate to the Login page.
        /// </summary>
        public void NavigateToLoginPage()
        {
            Driver.Navigate().GoToUrl(Configurator.Settings.UI.UIBaseUrl);
        }

        /// <summary>
        /// Login with valid username and password.
        /// </summary>
        public void LoginWithValidUsernameAndPassword()
        {
            _userNameField.SendKeys(GetValidUsername());
            _passwordField.SendKeys(GetValidPassword());
            _loginButton.Click();
        }

        /// <summary>
        /// Get valid username.
        /// </summary>
        /// <returns></returns>
        private string GetValidUsername()
        {
            var validUsername = GetStringSplitByNewLine(_validUsernames.Text, 1); 
            return validUsername;
        }

        /// <summary>
        /// Get valid password.
        /// </summary>
        /// <returns></returns>
        private string GetValidPassword()
        {
            var validPassword = GetStringSplitByNewLine(_validPasswords.Text, 1);
            return validPassword;
        }

        /// <summary>
        /// Get string split by new line.
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        private string GetStringSplitByNewLine(string lines, int line)
        {
            var splitLine = lines.Split("\r\n")[line];
            return splitLine;
        }
    }
}
