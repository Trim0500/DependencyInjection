using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class EbayProductServiceImpl : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product() {id = 1, name = "EbayProduct1", price = 19.99},
                new Product() {id = 2, name = "EbayProduct2", price = 19.99},
                new Product() {id = 3, name = "EbayProduct3", price = 19.99}
            };
        }
    }
}
