using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UIFramework.Pages.InventoryPage
{
    /// <summary>
    /// Inventory page map.
    /// </summary>
    public partial class InventoryPage
    {
        [FindsBy(How = How.ClassName, Using = "inventory_item")]
        public readonly IList<IWebElement> InventoryItems;

        [FindsBy(How = How.ClassName, Using = "shopping_cart_link")]
        private readonly IWebElement _shoppintCartLink;

        [FindsBy(How = How.ClassName, Using = "shopping_cart_badge")]
        private readonly IWebElement _shoppintCartBadge;

        [FindsBy(How = How.CssSelector, Using = "[data-test='product_sort_container']")]
        private readonly IWebElement _productSortDropdown;
    }
}
