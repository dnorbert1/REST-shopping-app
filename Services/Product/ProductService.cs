using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST.Domain;

namespace REST.Services.ProductService;

public class ProductService : IProductService
{
    public async Task<Product> GetById(int id)
    {
        return await Task.FromResult<Product>(new Product(1, "P1", "D1", 20.5));
    }
}
