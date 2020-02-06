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

        // [HttpGet]
        // public IEnumerable<Order> Get()
        // {
        //     using (OrderContext context = new OrderContext())
        //     {
        //         return context.Orders
        //                 .Include(o => o.OrderDetails)
        //                     .ThenInclude(od => od.Size)

        //                 .Include(o => o.OrderDetails)
        //                     .ThenInclude(od => od.Color)

        //                 .Include(o => o.OrderDetails)
        //                     .ThenInclude(od => od.Material)

        //                 .ToArray();
        //     }
        // }

        // GET order/2
        // [HttpGet("{id}")]
        // public ActionResult<Order> Get(int id)
        // {
        //     using (OrderContext context = new OrderContext())
        //     {
        //         return Ok(context.Orders
        //                 .Include(o => o.OrderDetails)
        //                     .ThenInclude(od => od.Size)

        //                 .Include(o => o.OrderDetails)
        //                     .ThenInclude(od => od.Color)

        //                 .Include(o => o.OrderDetails)
        //                     .ThenInclude(od => od.Material)

        //                 .First(o => o.Id == id));
        //     }
        // }

        // POST new Order
        [HttpPost]
        public ActionResult Order([FromBody] List<Product> cart)
        {
            const int Customer = 1;

            using (OrderContext context = new OrderContext())
            {
                // var res = context.OrderRows
                // .Where(or => or.CustomerId == Customer && or.OrderId == 1)
                // .ToList();

                // // check cart is not empty
                // if (res.Count == 0)
                // {
                //     return Ok();
                // }

                var newOrder = new Order()
                {
                    Status = "New",
                    CustomerId = Customer,
                    Created = DateTime.Now,
                };
                context.Orders.Add(newOrder);
                context.SaveChanges();

                foreach (var product in cart)
                {
                    OrderRow newOrd = new OrderRow();
                    newOrd.OrderId = newOrder.Id;
                    newOrd.ProductId = product.Id;
                    newOrd.SizeId = product.SizeId;
                    newOrd.ColorId = product.ColorId;
                    newOrd.MaterialId = product.MaterialId;

                    context.OrderRows.Add(newOrd);
                    //or.OrderId = newOrder.Id;
                }
                context.SaveChanges();

                return Created("", newOrder);

            }
        }
    }
}