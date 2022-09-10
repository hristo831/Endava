using NUnit.Framework;
using TechTalk.SpecFlow;
using UIFramework.Models;
using UIFramework.Pages.CartPage;

namespace UITests.Steps
{
    [Binding]
    public sealed class CartSteps
    {
        private readonly CartPage _cartPage;
        private ScenarioContext _scenarioContext;

        public CartSteps(CartPage cartPage, ScenarioContext scenarioContext)
        {
            _cartPage = cartPage;
            _scenarioContext = scenarioContext; 
        }

        [Then(@"The (first|penultimate) and the last items are added to the cart")]
        public void ThenTheFirstAndTheLastInventoryItemAreAddedToCart(string item)
        {
            switch (item)
            {
                case "first":
                    AssertItemsInfo("FirstAndLastItems");
                    break;

                case "penultimate":
                    AssertItemsInfo("PenultimateAndLastItems");
                    break;

                default:
                    break;
            }
        }

        [When(@"Remove the first item")]
        public void WhenRemoveTheFirstItem()
        {
            _cartPage.RemoveTheFirstCartItem();
        }

        [When(@"Click continue shopping")]
        public void WhenClickContinueShopping()
        {
            _cartPage.ClickContinueShopping();
        }

        [When(@"Click checkout")]
        [Given(@"Click checkout")]
        public void GivenClickCheckout()
        {
            _cartPage.ClickCheckout();
        }

        [Then(@"The cart is empty")]
        public void ThenTheCartIsEmpty()
        {
            _cartPage.AssertCartIsEmpty();
        }

        private void AssertItemsInfo(string contextItemsInfo)
        {
            var cartItems = _cartPage.GettCartItemsInfo().OrderBy(x => x.Name);
            var inventoryItems = _scenarioContext.Get<IEnumerable<ItemInfo>>(contextItemsInfo);

            CollectionAssert.AreEqual(inventoryItems, cartItems);
        }
    }
}
