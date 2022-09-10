using NUnit.Framework;

namespace UIFramework.Pages.CartPage
{
    /// <summary>
    /// Cart page asserter.
    /// </summary>
    public partial class CartPage
    {
        /// <summary>
        /// Assert cart is empty.
        /// </summary>
        public void AssertCartIsEmpty()
        {
            Assert.AreEqual(0, _cartItems.Count);
        }
    }
}
