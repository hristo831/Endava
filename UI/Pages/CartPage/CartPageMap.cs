using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UIFramework.Pages.CartPage
{
    /// <summary>
    /// Cart page map.
    /// </summary>
    public partial class CartPage
    {
        [FindsBy(How = How.ClassName, Using = "cart_item")]
        private readonly IList<IWebElement> _cartItems;

        [FindsBy(How = How.CssSelector, Using = "[data-test='continue-shopping']")]
        private readonly IWebElement _continueShoppingButton;

        [FindsBy(How = How.CssSelector, Using = "[data-test='checkout']")]
        private readonly IWebElement _checkoutButton;
    }
}
