using NUnit.Framework;
using OpenQA.Selenium;
using System.Globalization;
using System.Linq;

namespace UIFramework.Pages.InventoryPage
{
    /// <summary>
    /// Inventory page asserter.
    /// </summary>
    public partial class InventoryPage
    {
        /// <summary>
        /// Assert cart items count.
        /// </summary>
        /// <param name="cartItemsCount"></param>
        public void AssertShoppingCartBadgeItemsCount(string shoppingCartBadgeCount)
        {
            Assert.AreEqual(_shoppintCartBadge.Text, shoppingCartBadgeCount);
        }

        /// <summary>
        /// Assert the items are sorted from high to low price.
        /// </summary>
        public void AssertTheItemsAreSortedFromHighToLowPrice()
        {
            var itemPrices = new List<float>();

            foreach (var item in InventoryItems)
            {
                var itemPrice = item.FindElement(By.ClassName(_inventoryItemPriceClass));
                Assert.IsTrue(itemPrice.Displayed);

                var price = itemPrice.Text.Split("$")[1];
                var parsePrice = float.Parse(price, CultureInfo.InvariantCulture);
                itemPrices.Add(parsePrice);
            }

            var itemPricesSorted = itemPrices.OrderByDescending(x => x);

            CollectionAssert.AreEqual(itemPricesSorted, itemPrices);    
        }
    }
}
