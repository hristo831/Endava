using OpenQA.Selenium;
using UIFramework.Models;

namespace UIFramework.Pages.CartPage
{
    /// <summary>
    /// Cart page.
    /// </summary>
    public partial class CartPage : BaseOperations
    {
        public CartPage(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Get cart items info.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ItemInfo> GettCartItemsInfo()
        {
            var itemsInfo = new List<ItemInfo>();

            foreach (var item in _cartItems)
            {
                var itemInfo = GetItemsInfo(item);
                itemsInfo.Add(itemInfo);
            }

            return itemsInfo;
        }

        /// <summary>
        /// Remove the first cart item.
        /// </summary>
        public void RemoveTheFirstCartItem()
        {
            _cartItems.First().FindElement(By.TagName(_buttonTagName)).Click();
        }

        /// <summary>
        /// Click continue shoppint button.
        /// </summary>
        public void ClickContinueShopping()
        {
            _continueShoppingButton.Click();
        }

        /// <summary>
        /// Click checkout button.
        /// </summary>
        public void ClickCheckout()
        {
            _checkoutButton.Click();
        }
    }
}
