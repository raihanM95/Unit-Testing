using System;

namespace ECommerce
{
    public class PurchaseOrder
    {
        private ShoppingCart Cart { get; set; }
        private IInventory Inventory { get; set; }

        public string OrderNumber { get; set; }
        public string CustomerName { get; set; }

        // Dependency Injection
        public PurchaseOrder(ShoppingCart cart, IInventory inventory)
        {
            this.Cart = cart;
            this.Inventory = inventory;
        }

        public void AddToCart(Product product, uint quantity)
        {
            if (Inventory.IsItemAvailable(product, quantity))
                Cart.AddItem(product, quantity);
            else
                throw new Exception("Product not available");
        }
    }
}
