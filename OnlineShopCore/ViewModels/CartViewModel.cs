using OnlineShopCore.Models;

namespace OnlineShopCore.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            CartItems = new List<CartItem>();
        }

        public List<CartItem> CartItems { get; set; }
        public Decimal TotalOrder { get; set; }
    }
}
