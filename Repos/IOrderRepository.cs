using WebApplication4.Models;

namespace WebApplication4.Repos
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetAll();
        Task<Order> CreateAsync(Order order);
        Task<Order> GetByIdAsync(int orderId);
        public bool Update(Order order);
        public bool Delete(Order order);
    }
}
