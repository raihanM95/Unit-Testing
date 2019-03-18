using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ninject;
using Ninject.MockingKernel;
using Ninject.MockingKernel.Moq;

namespace ECommerce.Tests
{
    [TestClass]
    public class PurchaseOrderTests
    {
        MoqMockingKernel kernel = null;
        public PurchaseOrderTests()
        {
            kernel = new MoqMockingKernel();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Book book = new Book();

            ShoppingCart cart = new ShoppingCart();

            var inventoryMoq = kernel.GetMock<IInventory>();
            inventoryMoq.Setup(x => x.IsItemAvailable(book, 1)).Returns(true);

            PurchaseOrder purchaseOrder = new PurchaseOrder(cart, inventoryMoq.Object);
            purchaseOrder.AddToCart(book, 1);

            Assert.AreEqual(1, cart.Items.Count);
        }
    }
}
