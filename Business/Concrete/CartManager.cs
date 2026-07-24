using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductID == product.ProductID);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            else
            {
                cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
            }
        }

        public List<CartLine> List(Cart cart)
        {
           return cart.CartLines
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductID == productId));
        }
    }
}
