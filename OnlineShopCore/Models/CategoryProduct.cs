namespace OnlineShopCore.Models
{
    public class CategoryProduct
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        #region navigation properties

        public Product Product { get; set; }
        public Product Category { get; set; }

        #endregion

    }
}
