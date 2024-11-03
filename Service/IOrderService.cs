using WebApplication4.Models;
using WebApplication4.Dto;
namespace WebApplication4.Service
{
    public interface IOrderService
    {
            Task<Order> CreateOrderAsync(Order order);
    }
}
