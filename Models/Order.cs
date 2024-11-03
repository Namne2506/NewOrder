using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }

        
        public DateTime? OrderDate { get; set; } 

        public int? CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        public Order() 
        {

        }

        public Order(int orderId, DateTime? orderDate, int? customerId)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            CustomerId = customerId;
        }

        
    }
}
