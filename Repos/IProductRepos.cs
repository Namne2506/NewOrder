using WebApplication4.Models;

namespace WebApplication4.Repos
{
    public interface IProductRepos
    {
        Task<Product> GetProductByIdAsync(int productId);
    }
}
