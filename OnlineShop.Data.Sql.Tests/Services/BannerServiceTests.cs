using OnlineShop.Data.Sql.Services;
using OnlineShop.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OnlineShop.Data.Sql.Tests.Services
{
    public class BannerServiceTests : TestBase
    {
        private readonly List<Banner> banners;

        public BannerServiceTests()
        {
            // Arrange
            banners = new List<Banner> {
                new Banner { Id = 1, Name = "Carousel1", Description = "We sell the best pies in the town!", ImageUrl = "/images/carousel1.jpg" },
                new Banner { Id = 2, Name = "Carousel2", Description = "We sell the best pies in the town!", ImageUrl = "/images/carousel2.jpg" },
                new Banner { Id = 3, Name = "Carousel3", Description = "We sell the best pies in the town!", ImageUrl = "/images/carousel3.jpg" }
            };

            dbContext.Banner.AddRange(banners);
            dbContext.SaveChanges();
        }

        [Fact]
        public async Task GetBannersAsync_WhenCalled_ReturnsAllBanners()
        {
            // Arrange
            var sut = new BannerService(dbContext);

            // Act
            var result = await sut.GetBannersAsync();

            // Assert
            Assert.Equal(banners.Count, result.Count());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public async Task GetBannerAsync_WhenCalledWithValidId_ReturnsBannerOfGivenId(int bannerId)
        {
            // Arrange
            var sut = new BannerService(dbContext);

            // Act
            var result = await sut.GetBannerAsync(bannerId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(bannerId, result.Id);
        }

        [Fact]
        public async Task GetBannerAsync_WhenCalledWithInvalidId_ReturnsNull()
        {
            // Arrange
            int bannerId = 4;
            var sut = new BannerService(dbContext);

            // Act
            var result = await sut.GetBannerAsync(bannerId);

            // Assert
            Assert.Null(result);
        }
    }
}
