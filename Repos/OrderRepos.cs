using System.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.Repos
{
    public class OrderRepos : IOrderRepository
    {
        private readonly SalesApplicationContext context;

        public OrderRepos(SalesApplicationContext context)
        {
            this.context = context;
        }

        

        public async Task<Order> CreateAsync(Order order)
        {
            await context.AddAsync(order);
            await context.SaveChangesAsync();
            return order;
        }

        public bool Delete(Order order)
        {
            try
            {
                context.Remove(order);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public async Task<Order> GetByIdAsync(int orderId)
        {
            return await context.Orders.FirstOrDefaultAsync(o => o.OrderId == o.OrderId);
        }

        public bool Update(Order order)
        {
            try
            {
                context.Update(order);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
