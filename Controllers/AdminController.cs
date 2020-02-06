using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onlineTShirtShop.Models;
using onlineTShirtShop.OrderContexts;

namespace onlineTShirtShop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        // GET admin/ListOrder
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            using (OrderContext context = new OrderContext())
            {
                return context.Orders
                        .Include(o => o.OrderRows)
                            .ThenInclude(od => od.Size)

                        .Include(o => o.OrderRows)
                            .ThenInclude(od => od.Color)

                        .Include(o => o.OrderRows)
                            .ThenInclude(od => od.Material)
                        .Include(o => o.OrderRows)
                            .ThenInclude(od => od.Product)
                        .ToList();
            }

        }



        // GET admin/2
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            using (OrderContext context = new OrderContext())
            {
                return Ok(context.Orders.First(o => o.Id == id));
            }
        }

        // POST admin new Order
        [HttpPost]
        public ActionResult Order([FromBody] Order newOrder)
        {
            using (OrderContext context = new OrderContext())
            {
                context.Orders.Add(newOrder);
                context.SaveChanges();
                return Created("", newOrder);

            }
        }

        // PUT admin/id         
        [HttpPut("{id}")]
        public ActionResult<Order> Put(int id, [FromBody] Order updatedOrder)
        {
            using (OrderContext context = new OrderContext())
            {
                Order o = context.Orders.First(o => o.Id == id);
                o.Status = updatedOrder.Status;
                context.SaveChanges();

                return Ok();
            }
        }

        // DELETE admin/3
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            using (OrderContext context = new OrderContext())
            {
                Order o = context.Orders.First(o => o.Id == id);
                context.Remove(o);
                context.SaveChanges();

                return NoContent();
            }
        }
    }
}

