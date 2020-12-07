using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sneakersShoesShop.OrderContexts;
using sneakersShoesShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace sneakersShoesShop.Controllers
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
                return context.OrderRows
                .Where(or => or.OrderId == 1)
                .Include(or => or.Product)
                .Include(or => or.Size)
                .Include(or => or.Color)
                .Include(or => or.Material)
                .ToList();
            }
        }

        // POST add Row
        [HttpPost("{ProductId}")]
        public ActionResult OrderRow(int ProductId)
        {
            using (OrderContext context = new OrderContext())
            {
                var product = context.Products
                    .First(everyProduct => everyProduct.Id == ProductId);
                var newOrderRow = new OrderRow
                {
                    OrderId = 1,
                    CustomerId = 1,
                    Quantity = 1,
                    ProductId = ProductId,
                    ColorId = product.ColorId,
                    SizeId = product.SizeId,
                    MaterialId = product.MaterialId
                };
                context.OrderRows.Add(newOrderRow);
                context.SaveChanges();
                return Created("", newOrderRow);

            }
        }

        // DELETE row in order
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            using (OrderContext context = new OrderContext())
            {
                OrderRow or = context.OrderRows
                .First(or => or.Id == id);
                context.Remove(or);
                context.SaveChanges();

                return NoContent();
            }
        }

    }
}