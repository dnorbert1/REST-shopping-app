using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST.Domain;

namespace REST.Services.ProductService;
public interface IProductService
{
    Task<Product> GetById(int id);
}
