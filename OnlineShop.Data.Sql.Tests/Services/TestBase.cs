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
            var options = new DbContextOptionsBuilder<OnlineShopContext>()
                                .UseInMemoryDatabase($"InMemory-{Guid.NewGuid()}")
                                .Options;
            dbContext = new OnlineShopContext(options);
        }
    }
}
