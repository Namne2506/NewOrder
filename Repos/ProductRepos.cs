using System.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.Repos
{
    public class ProductRepos : IProductRepos
    {
        private readonly SalesApplicationContext context;
        private readonly DbSet<Product> products;

        public ProductRepos(SalesApplicationContext context, DbSet<Product> products)
        {
            this.context = context;
            this.products = products;
        }

        

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await context.Products.FirstOrDefaultAsync(p => p.ProductId == productId);
        }
    }
}
