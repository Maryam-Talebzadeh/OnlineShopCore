﻿namespace OnlineShopCore.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemId { get; set; }

        #region navigations

        public List<CategoryProduct> CategoryProducts { get; set; }
        public Item Item { get; set; }

        #endregion
    }
}
