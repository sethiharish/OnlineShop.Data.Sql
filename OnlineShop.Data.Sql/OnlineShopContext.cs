using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Data.Sql
{
    public class OnlineShopContext : DbContext
    {
        public OnlineShopContext(DbContextOptions<OnlineShopContext> options) : base(options)
        {

        }

        public DbSet<Banner> Banner { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Pie> Pie { get; set; }
    }
}
