using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SneakersShoesShop.Models;
using SneakersShoesShop.OrderContexts;

namespace SneakersShoesShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            using (OrderContext context = new OrderContext())
            {
                return context.Products
                    .Include(p => p.Size)
                    .Include(p => p.Color)
                    .Include(p => p.Material)
                    .ToList();
            }
        }


        // GET product/2
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            using OrderContext context = new OrderContext();
            return Ok(context.Products
                .Include(p => p.Size)
                .Include(p => p.Color)
                .Include(p => p.Material)
                .First(everyProduct => everyProduct.Id == id));
        }
    }
}