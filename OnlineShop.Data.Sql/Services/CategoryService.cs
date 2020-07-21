using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.Services;
using OnlineShop.Entities;
using System;
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

        public async Task<Category> GetCategoryByNameAsync(string category)
        {
            return await context.Category.FirstOrDefaultAsync(c => c.NormalizedName == category.Trim().ToUpper());
        }
    }
}
