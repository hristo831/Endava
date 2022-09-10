using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UIFramework.Models;

namespace UIFramework.Pages.InventoryPage
{
    /// <summary>
    /// Inventory page.
    /// </summary>
    public partial class InventoryPage : BaseOperations
    {
        public InventoryPage(IWebDriver driver)
            : base(driver)
        {
        }

        private string _remoteButtonText = "REMOVE";

        /// <summary>
        /// Add or remove inventory item.
        /// </summary>
        /// <param name="inventoryItem"></param>
        public void AddRemoveInventoryItem(int inventoryItem)
        {
            InventoryItems[inventoryItem].FindElement(By.TagName(_buttonTagName)).Click();
        }

        /// <summary>
        /// Get inventory items info.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ItemInfo> GettInventoryItemsInfo()
        {
            var itemsInfo = new List<ItemInfo>();

            foreach (var item in InventoryItems)
            {
                if (item.FindElement(By.TagName(_buttonTagName)).Text == _remoteButtonText)
                {
                    var itemInfo = GetItemsInfo(item);
                    itemsInfo.Add(itemInfo);    
                }
            }

            return itemsInfo;
        }

        /// <summary>
        /// Click shopping cart badge.
        /// </summary>
        public void ClickShoppingCartBadge()
        {
            _shoppintCartLink.Click();
        }

        /// <summary>
        /// Select price high to low.
        /// </summary>
        public void SelectPriceHighToLow()
        {
            var productSortDropdown = new SelectElement(_productSortDropdown);
            productSortDropdown.SelectByValue("hilo");
        }

    }
}
