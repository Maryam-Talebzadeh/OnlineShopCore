using Microsoft.EntityFrameworkCore;
using OnlineShopCore.Models;

namespace OnlineShopCore.DataAccess
{
    public class OnlineShopCoreContext : DbContext
    {
        public OnlineShopCoreContext(DbContextOptions<OnlineShopCoreContext> options) :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed data

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Title = "Asp.netcore"
                }
                );

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
