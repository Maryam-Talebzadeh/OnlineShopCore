namespace OnlineShopCore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
