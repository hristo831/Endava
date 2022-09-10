using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UIFramework.Models;

namespace UIFramework.Pages
{
    /// <summary>
    /// Base operations.
    /// </summary>
    public class BaseOperations : BasePage
    {
        private const string _titleClass = "title";
        private const string _inventoryItemNameClass = "inventory_item_name";
        private const string _inventoryItemDescClass = "inventory_item_desc";
        public const string _inventoryItemPriceClass = "inventory_item_price";
        private const string _baseUrl = "https://www.saucedemo.com";
        public const string _buttonTagName = "button";

        [FindsBy(How = How.ClassName, Using = _titleClass)]
        private readonly IWebElement _pageTitle;

        [FindsBy(How = How.Id, Using = "react-burger-menu-btn")]
        private readonly IWebElement _hamburgerMenu;

        [FindsBy(How = How.Id, Using = "logout_sidebar_link")]
        private readonly IWebElement _logout;

        public BaseOperations(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Assert page url.
        /// </summary>
        /// <param name="pageUrl"></param>
        public void AssertPageUrl(string partialPageUrl)
        {
            Assert.AreEqual(_baseUrl + partialPageUrl, Driver.Url);
        }

        /// <summary>
        /// Assert page title.
        /// </summary>
        /// <param name="pageTitle"></param>
        public void AssertPageTitle(string pageTitle)
        {
            Assert.IsTrue(_pageTitle.Displayed);
            Assert.AreEqual(pageTitle, _pageTitle.Text);
        }

        /// <summary>
        /// Get inventory item info.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public ItemInfo GetItemsInfo(IWebElement item)
        {
            var itemName = item.FindElement(By.ClassName(_inventoryItemNameClass));
            var itemDescription = item.FindElement(By.ClassName(_inventoryItemDescClass));
            var itemPrice = item.FindElement(By.ClassName(_inventoryItemPriceClass));

            Assert.IsTrue(itemName.Displayed);
            Assert.IsTrue(itemDescription.Displayed);
            Assert.IsTrue(itemPrice.Displayed);

            ItemInfo itemInfo = new ItemInfo()
            {
                Name = itemName.Text,
                Description = itemDescription.Text,
                Price = itemPrice.Text
            };
            
            return itemInfo;
        }

        /// <summary>
        /// Logout.
        /// </summary>
        public void Logout()
        {
            _hamburgerMenu.Click();
            WaitUntilElementDisplayed(_logout);
            _logout.Click();
        }

        /// <summary>
        /// Wait until element displayed.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="reTryCount"></param>
        /// <returns></returns>
        public static bool WaitUntilElementDisplayed(IWebElement element, int reTryCount = 40)
        {
            for (int i = 0; i < reTryCount; i++)
            {
                try
                {
                    if (element.Displayed.Equals(true))
                        return element.Displayed;
                }
                catch (NoSuchElementException)
                {
                }
                Thread.Sleep(TimeSpan.FromMilliseconds(250));
            }
            return false;
        }
    }
}
