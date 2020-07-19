using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.Services;
using OnlineShop.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Data.Sql.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly OnlineShopContext context;

        public CategoryService(OnlineShopContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await context.Category.ToListAsync();
        }

        public async Task<Category> GetCategoryAsync(int categoryId)
        {
            return await context.Category.FindAsync(categoryId);
        }
    }
}
