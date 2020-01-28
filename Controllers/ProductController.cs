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
                .ToList();
            }
        }
    

        // GET product/2
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            using (OrderContext context = new OrderContext())
            {
                return Ok(context.Products.First(o => o.Id == id));
            }
        }
    }
}