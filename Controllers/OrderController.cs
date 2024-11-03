using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Repos;
using WebApplication4.Service;

namespace WebApplication4.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderRepos repos;

        public OrderController(OrderRepos repos)
        {
            this.repos = repos;
        }

        [HttpPost("createOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
            if(order == null)
            {
                return NotFound();
            }
            try
            {
                var data = repos.CreateAsync(order);
                return StatusCode(201, data);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
