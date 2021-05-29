using System;
using System.Net.Http;
using MongoDbApi.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlazorMongoDbClient.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public Task DeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductDetails(string id)
        {
            throw new NotImplementedException();
        }

        public Task SaveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
