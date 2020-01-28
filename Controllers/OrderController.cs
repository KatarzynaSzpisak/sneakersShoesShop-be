using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onlineTShirtShop.OrderContexts;
using onlineTShirtShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace onlineTShirtShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            using (OrderContext context = new OrderContext())
            {
                return context.Orders
                        .Include(o => o.OrderDetails)
                            .ThenInclude(od => od.Size)

                        .Include(o => o.OrderDetails)
                            .ThenInclude(od => od.Color)

                        .Include(o => o.OrderDetails)
                            .ThenInclude(od => od.Material)
                            
                        .ToArray();
            }
        }

        // GET order/2
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            using (OrderContext context = new OrderContext())
            {
                return Ok(context.Orders
                        .Include(o => o.OrderDetails)
                            .ThenInclude(od => od.Size)

                        .Include(o => o.OrderDetails)
                            .ThenInclude(od => od.Color)

                        .Include(o => o.OrderDetails)
                            .ThenInclude(od => od.Material)
                            
                        .First(o => o.Id == id));
            }
        }

    }
}