using OpenQA.Selenium;
using UIFramework.Models;

namespace UIFramework.Pages.CheckoutStepOnePage
{
    /// <summary>
    /// Checkout step one page.
    /// </summary>
    public partial class CheckoutStepOnePage : BaseOperations
    {
        public CheckoutStepOnePage(IWebDriver driver)
            : base(driver) 
        { 
        }

        /// <summary>
        /// Fill my information.
        /// </summary>
        /// <param name="myInfo"></param>
        public void FillMyInformation(MyInfo myInfo)
        {
            _firstNameField.SendKeys(myInfo.FirstName);
            _lastNameField.SendKeys(myInfo.LastName);
            _zipCodeField.SendKeys(myInfo.ZipCode); 
        }

        /// <summary>
        /// Click continue button.
        /// </summary>
        public void ClickContinue()
        {
            _continueButton.Click();    
        }
    }
}
