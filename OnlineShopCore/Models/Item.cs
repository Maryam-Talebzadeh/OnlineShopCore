namespace OnlineShopCore.Models
{
    public class Item
    {
        public int Id { get; set; }
        public Decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public int ProductId { get; set; }

        #region navigations

        public Product Product { get; set; }

        #endregion
    }
}
