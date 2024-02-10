namespace OnlineShopCore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }


        #region navigations

        public List<CategoryProduct> CategoryProducts { get; set; }

        #endregion
    }
}
