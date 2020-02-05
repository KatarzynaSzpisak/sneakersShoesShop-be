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
    public class OrderRowController : ControllerBase
    {
        private readonly ILogger<OrderRowController> _logger;

        public OrderRowController(ILogger<OrderRowController> logger)
        {
            _logger = logger;
        }


        // GET orderRow
        [HttpGet("{id}")]
        public IEnumerable<OrderRow> List(int OrderId)
        {
            using (OrderContext context = new OrderContext())
            {
                return context.OrderRows.ToList();
            }
        }

        // POST add Row
        [HttpPost("{id}")]
        public ActionResult OrderRow (int ProductId)
        {
            using (OrderContext context = new OrderContext())
            {
                var newOrderRow = new OrderRow{
                    OrderId = 1,
                    CustomerId = 1
                };
                context.OrderRows.Add(newOrderRow);
                context.SaveChanges();
                return Created("", newOrderRow);

            }
        }

        // // PUT admin/id         
        // [HttpPut("{id}")]
        // public ActionResult<OrderRow> Put(int id, [FromBody] Order updatedOrder)
        // {
        //     using (OrderContext context = new OrderContext())
        //     {
        //         Order o = context.Orders.First(o => o.Id == id);
        //         o.Status = updatedOrder.Status;
        //         context.SaveChanges();

        //         return Ok();
        //     }
        // }

        // // DELETE row in order
        // [HttpDelete("{id}")]
        // public ActionResult Delete(int id)
        // {
        //     using (OrderContext context = new OrderContext())
        //     {
        //         Order o = context.Orders.newOrderRow.First(o => o.Id == id);
        //         context.Remove(o);
        //         context.SaveChanges();

        //         return NoContent();
        //     }
        // }

    }
}