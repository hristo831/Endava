using NUnit.Framework;
using TechTalk.SpecFlow;
using UIFramework.Models;
using UIFramework.Pages.CartPage;
using UIFramework.Pages.InventoryPage;

namespace UITests.Steps
{
    [Binding]
    public sealed class InventorySteps
    {
        private readonly InventoryPage _inventoryPage;
        private ScenarioContext _scenarioContext;

        public InventorySteps(InventoryPage inventoryPage,
            CartPage cartPage,
            ScenarioContext scenarioContext)
        {
            _inventoryPage = inventoryPage;
            _scenarioContext = scenarioContext;
        }

        [Given(@"Add the (first|last|penultimate) inventory item to the cart")]
        [When(@"Add the (first|last|penultimate) inventory item to the cart")]
        public void WhenAddTheInventoryItemToTheCart(string inventoryItem)
        {
            switch (inventoryItem)
            {
                case "first":
                    _inventoryPage.AddRemoveInventoryItem(inventoryItem: 0);
                    break;

                case "last":
                    _inventoryPage.AddRemoveInventoryItem(inventoryItem: _inventoryPage.InventoryItems.Count - 1);
                    break;

                case "penultimate":
                    _inventoryPage.AddRemoveInventoryItem(inventoryItem: _inventoryPage.InventoryItems.Count - 2);
                    break;

                default:
                    break;
            }
        }

        [When(@"Get the (first|penultimate) and the last inventory items information")]
        public void WhenGetTheFirstAndTheLastInventoryItemInfo(string item)
        {
            var inventoryItems = _inventoryPage.GettInventoryItemsInfo().OrderBy(x => x.Name);
            switch (item)
            {
                case "first":
                    _scenarioContext.Add("FirstAndLastItems", inventoryItems);
                    break;

                case "penultimate":
                    _scenarioContext.Add("PenultimateAndLastItems", inventoryItems);
                    break;

                default:
                    break;
            }
        }

        [Given(@"Click shopping cart badge")]
        [When(@"Click shopping cart badge")]
        public void WhenClickShoppingCartBadge()
        {
             _inventoryPage.ClickShoppingCartBadge();
        }


        [Then(@"""([^""]*)"" items are added to the shopping cart badge")]
        public void ThenItemsAreAddedToTheShoppingCartBadge(string shoppingCartBadgeCount)
        {
            _inventoryPage.AssertShoppingCartBadgeItemsCount(shoppingCartBadgeCount);
        }

        [When(@"Select price high to low")]
        public void WhenSelectPriceHighToLow()
        {
            _inventoryPage.SelectPriceHighToLow();
        }

        [Then(@"The items are sorted from high to low price")]
        public void ThenTheItemsAreSortedFromHighToLowPrice()
        {
            _inventoryPage.AssertTheItemsAreSortedFromHighToLowPrice();
        }
    }
}
