using System.Data.Entity;
namespace WebApplication4.Repos
{
    public interface IOrderDetailsRepos
    {
            Task<bool> CreateAsync(OrderDetail orderDetail); 
    }
}
