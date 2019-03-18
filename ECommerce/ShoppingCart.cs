using System;
using System.Collections.Generic;

namespace ECommerce
{
    public class ShoppingCart
    {
        public List<CartItem> Items { get; set; }

        public ShoppingCart()
        {
            Items = new List<CartItem>();
        }

        public void AddItem(Product product, uint quantity)
        {
            Items.Add(new CartItem() 
                { CartProduct = product, Quantity = quantity });
        }

        public void RemoveItem(Product product)
        {
            CartItem fitem = null;
            foreach(var item in Items)
            {
                if (item.CartProduct.Name == product.Name)
                {
                    fitem = item;
                    break;
                }
            }
            Items.Remove(fitem);
        }

        public void Reset()
        {
            Items = new List<CartItem>();
        }
    }
}
