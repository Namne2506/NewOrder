using WebApplication4.Dto;
using WebApplication4.Models;
using WebApplication4.Repos;
using WebApplication4.Exceptions;

namespace WebApplication4.Service
{
    public class OrderService :  IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepos _productRepository;
        private readonly IOrderDetailsRepos _orderDetailsRepository;

        public OrderService(IOrderRepository orderRepository, IProductRepos productRepository, IOrderDetailsRepos orderDetailsRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _orderDetailsRepository = orderDetailsRepository;
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            var _order = await _orderRepository.GetByIdAsync(order.OrderId);
            if (_order == null) { 
            var orderN = new Order
            {
                OrderId = order.OrderId,
                OrderDate = DateTime.UtcNow,
                CustomerId = order.CustomerId,
                OrderDetails = new List<OrderDetail>()
            };
        }
                foreach (var detail in order.OrderDetails)
                {
                     var _product = await _productRepository.GetProductByIdAsync(detail.ProductId.Value);
                     if(_product == null)
                {
                    throw new ValidateException($"Product is null with id {detail.ProductId}");
                }
                    var orderDetail = new OrderDetail
                    {
                        OrderId = order.OrderId,
                        ProductId = detail.ProductId,
                        Quantity = detail.Quantity,
                        UnitPrice = detail.UnitPrice 
                    };

                    order.OrderDetails.Add(orderDetail); 
                }
                await _orderRepository.CreateAsync(order);
                return order;

        }


    }
}
