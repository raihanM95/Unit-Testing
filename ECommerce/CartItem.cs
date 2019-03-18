using System;

namespace ECommerce
{
    public class CartItem
    {
        public Product CartProduct { get; set; }
        public uint Quantity { get; set; }

        public double Subtotal()
        {
            return CartProduct.Price * Quantity;
        }
    }
}
