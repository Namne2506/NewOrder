namespace WebApplication4.Dto
{
    public class OrderRequestDto
    {
            public int CustomerId { get; set; }
            public List<OrderDetail>  OrderDetails   { get; set; }
    }
}
