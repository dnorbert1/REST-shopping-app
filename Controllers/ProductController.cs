using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST.Domain;
using REST.Services.ProductService;

namespace REST.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController
        (
            ILogger<ProductController> logger,
            IProductService productService
        )
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet(Name = "GetProductById")]
        [Route("{id}")]
        public Task<Product> GetProductById(int id)
        {
            return _productService.GetById(id);
        }
    }
}