using OnlineShop.Data.Sql.Services;
using OnlineShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OnlineShop.Data.Sql.Tests.Services
{
    public class PieServiceTests : TestBase
    {
        private readonly List<Pie> pies;
        private readonly int piesOfTheWeekCount;

        public PieServiceTests()
        {
            // Arrange
            var categoryFruitPies = new Category { Id = 1, Name = "Fruit pies", NormalizedName = "FRUIT PIES", Description = "Fruit pies" };
            var categoryCheeseCakes = new Category { Id = 2, Name = "Cheese cakes", NormalizedName = "CHEESE CAKES", Description = "Cheese cakes" };
            var categorySeasonalPies = new Category { Id = 3, Name = "Seasonal pies", NormalizedName = "SEASONAL PIES", Description = "Seasonal pies" };
            
            string longDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.";

            pies = new List<Pie> {
                new Pie
                {
                    Id = 1,
                    Name = "Apple Pie",
                    Price = 12.95M,
                    ShortDescription = "Our famous apple pies!",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/applepie.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/applepiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true,
                    Category = categoryFruitPies
                },
                new Pie
                {
                    Id = 2,
                    Name = "Blueberry Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "You'll love it!",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/blueberrycheesecake.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/blueberrycheesecakesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    Category = categoryCheeseCakes
                },
                new Pie
                {
                    Id = 3,
                    Name = "Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "Plain cheese cake. Plain pleasure.",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/cheesecake.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/cheesecakesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    Category = categoryCheeseCakes
                },
                new Pie
                {
                    Id = 4,
                    Name = "Cherry Pie",
                    Price = 15.95M,
                    ShortDescription = "A summer classic!",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/cherrypie.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/cherrypiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    Category = categoryFruitPies
                },
                new Pie
                {
                    Id = 5,
                    Name = "Christmas Apple Pie",
                    Price = 13.95M,
                    ShortDescription = "Happy holidays with this pie!",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/christmasapplepie.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/christmasapplepiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    Category = categorySeasonalPies
                },
                new Pie
                {
                    Id = 6,
                    Name = "Cranberry Pie",
                    Price = 17.95M,
                    ShortDescription = "A Christmas favorite",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/cranberrypie.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/cranberrypiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    Category = categorySeasonalPies
                },
                new Pie
                {
                    Id = 7,
                    Name = "Peach Pie",
                    Price = 15.95M,
                    ShortDescription = "Sweet as peach",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/peachpie.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/peachpiesmall.jpg",
                    InStock = false,
                    IsPieOfTheWeek = false,
                    Category = categoryFruitPies
                },
                new Pie
                {
                    Id = 8,
                    Name = "Pumpkin Pie",
                    Price = 12.95M,
                    ShortDescription = "Our Halloween favorite",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/pumpkinpie.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/pumpkinpiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true,
                    Category = categorySeasonalPies
                },
                new Pie
                {
                    Id = 9,
                    Name = "Rhubarb Pie",
                    Price = 15.95M,
                    ShortDescription = "My God, so sweet!",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/rhubarbpie.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/rhubarbpiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true,
                    Category = categoryFruitPies
                },
                new Pie
                {
                    Id = 10,
                    Name = "Strawberry Pie",
                    Price = 15.95M,
                    ShortDescription = "Our delicious strawberry pie!",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/strawberrypie.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/strawberrypiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    Category = categoryFruitPies
                },
                new Pie
                {
                    Id = 11,
                    Name = "Strawberry Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "You'll love it!",
                    LongDescription = longDescription,
                    ImageUrl = "/images/pies/strawberrycheesecake.jpg",
                    ThumbnailImageUrl = "/images/pies/thumbnails/strawberrycheesecakesmall.jpg",
                    InStock = false,
                    IsPieOfTheWeek = false,
                    Category = categoryCheeseCakes
                }
            };

            piesOfTheWeekCount = pies.Count(p => p.IsPieOfTheWeek);

            //dbContext.Category.AddRange(categories);
            dbContext.Pie.AddRange(pies);
            dbContext.SaveChanges();
        }

        [Fact]
        public async Task GetPiesAsync_WhenCalled_ReturnsAllPiesWithCategory()
        {
            // Arrange
            var sut = new PieService(dbContext);

            // Act
            var result = await sut.GetPiesAsync();

            // Assert
            Assert.Equal(pies.Count, result.Count());
            Assert.NotNull(result.First().Category);
            Assert.NotNull(result.Last().Category);
        }

        [Fact]
        public async Task GetPiesOfTheWeekAsync_WhenCalled_ReturnsAllPiesOfTheWeekWithCategory()
        {
            // Arrange
            var sut = new PieService(dbContext);

            // Act
            var result = await sut.GetPiesOfTheWeekAsync();

            // Assert
            Assert.Equal(piesOfTheWeekCount, result.Count());
            Assert.NotNull(result.First().Category);
            Assert.NotNull(result.Last().Category);
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        public async Task GetPieAsync_WhenCalledWithValidId_ReturnsPieOfGivenIdWithCategory(int pieId)
        {
            // Arrange
            var sut = new PieService(dbContext);

            // Act
            var result = await sut.GetPieAsync(pieId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(pieId, result.Id);
            Assert.NotNull(result.Category);
        }

        [Fact]
        public async Task GetPieAsync_WhenCalledWithInvalidId_ReturnsNull()
        {
            // Arrange
            int pieId = 12;
            var sut = new PieService(dbContext);

            // Act
            var result = await sut.GetPieAsync(pieId);

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
        public async Task GetPiesByCategoryAsync_WhenCalledWithValidCategoryIgnoringCase_ReturnsAllPiesOfGivenCategoryWithCategory(string category)
        {
            // Arrange
            var sut = new PieService(dbContext);

            // Act
            var result = await sut.GetPiesByCategoryAsync(category);

            // Assert
            Assert.Equal(pies.Count(p => p.Category.Name.Equals(category, StringComparison.InvariantCultureIgnoreCase)), result.Count());
            Assert.NotNull(result.First().Category);
            Assert.NotNull(result.Last().Category);
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
        public async Task GetPiesByCategoryAsync_WhenCalledWithInvalidCategoryIgnoringCase_ReturnsNull(string category)
        {
            // Arrange
            var sut = new PieService(dbContext);

            // Act
            var result = await sut.GetPiesByCategoryAsync(category);

            // Assert
            Assert.Empty(result);
        }
    }
}
