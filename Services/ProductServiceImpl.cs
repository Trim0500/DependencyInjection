using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class ProductServiceImpl : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product() {id = 1, name = "Product1", price = 19.99},
                new Product() {id = 2, name = "Product2", price = 19.99},
                new Product() {id = 3, name = "Product3", price = 19.99}
            };
        }
    }
}
