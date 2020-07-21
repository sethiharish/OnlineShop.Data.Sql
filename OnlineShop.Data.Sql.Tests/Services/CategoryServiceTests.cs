using OnlineShop.Data.Sql.Services;
using OnlineShop.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OnlineShop.Data.Sql.Tests.Services
{
    public class CategoryServiceTests : TestBase
    {
        private readonly List<Category> categories;
        
        public CategoryServiceTests()
        {
            // Arrange
            var categoryFruitPies = new Category { Id = 1, Name = "Fruit pies", NormalizedName = "FRUIT PIES", Description = "Fruit pies" };
            var categoryCheeseCakes = new Category { Id = 2, Name = "Cheese cakes", NormalizedName = "CHEESE CAKES", Description = "Cheese cakes" };
            var categorySeasonalPies = new Category { Id = 3, Name = "Seasonal pies", NormalizedName = "SEASONAL PIES", Description = "Seasonal pies" };
            categories = new List<Category> { categoryFruitPies, categoryCheeseCakes, categorySeasonalPies };
            
            dbContext.Category.AddRange(categories);
            dbContext.SaveChanges();
        }

        [Fact]
        public async Task GetCategoriesAsync_WhenCalled_ReturnsAllCategories()
        {
            // Arrange
            var sut = new CategoryService(dbContext);

            // Act
            var result = await sut.GetCategoriesAsync();

            // Assert
            Assert.Equal(categories.Count, result.Count());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public async Task GetCategoryAsync_WhenCalledWithValidId_ReturnsCategoryOfGivenId(int categoryId)
        {
            // Arrange
            var sut = new CategoryService(dbContext);

            // Act
            var result = await sut.GetCategoryAsync(categoryId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(categoryId, result.Id);
        }

        [Fact]
        public async Task GetCategoryAsync_WhenCalledWithInvalidId_ReturnsNull()
        {
            // Arrange
            int categoryId = 4;
            var sut = new CategoryService(dbContext);

            // Act
            var result = await sut.GetCategoryAsync(categoryId);

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData("Fruit pies")]
        [InlineData("FRUIT PIES")]
        [InlineData("fruit pies")]
        [InlineData("Cheese cakes")]
        [InlineData("CHEESE CAKES")]
        [InlineData("cheese cakes")]
        [InlineData("Seasonal pies")]
        [InlineData("SEASONAL PIES")]
        [InlineData("seasonal pies")]
        public async Task GetCategoryByNameAsync_WhenCalledWithValidCategoryNameIgnoringCase_ReturnsCategoryOfGivenCategoryName(string category)
        {
            // Arrange
            var sut = new CategoryService(dbContext);

            // Act
            var result = await sut.GetCategoryByNameAsync(category);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(category, result.Name, true);
        }

        [Theory]
        [InlineData("Fruit pie")]
        [InlineData("FRUIT  PIES")]
        [InlineData("fruits pies")]
        [InlineData("Cheese cake")]
        [InlineData("CHEESE  CAKES")]
        [InlineData("cheesee cakes")]
        [InlineData("Seasonal pie")]
        [InlineData("SEASONAL  PIES")]
        [InlineData("seasonall pies")]
        public async Task GetCategoryByNameAsync_WhenCalledWithInvalidCategoryNameIgnoringCase_ReturnsNull(string category)
        {
            // Arrange
            var sut = new CategoryService(dbContext);

            // Act
            var result = await sut.GetCategoryByNameAsync(category);

            // Assert
            Assert.Null(result);
        }
    }
}
