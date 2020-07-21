using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;

namespace OnlineShop.Data.Sql.Tests.Services
{
    public abstract class TestBase
    {
        protected readonly OnlineShopContext dbContext;
        
        public TestBase()
        {
            // Arrange
            var connection = new SqliteConnection("DataSource = :memory:");
            
            var options = new DbContextOptionsBuilder<OnlineShopContext>()
                                .UseSqlite(connection)
                                .Options;

            dbContext = new OnlineShopContext(options);
            
            dbContext.Database.OpenConnection();
            dbContext.Database.EnsureCreated();
        }
    }
}
