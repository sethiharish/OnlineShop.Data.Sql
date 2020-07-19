using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace OnlineShop.Data.Sql
{
    class OnlineShopContextFactory : IDesignTimeDbContextFactory<OnlineShopContext>
    {
        public OnlineShopContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json")
                                        .Build();

            var optionsBuilder = new DbContextOptionsBuilder<OnlineShopContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                options => options.MigrationsAssembly("OnlineShop.Data.Sql.Migrations"));

            return new OnlineShopContext(optionsBuilder.Options);
        }
    }
}
