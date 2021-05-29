using MongoDbApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMongoDbClient.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductDetails(string id);
        Task SaveProduct(Product product);
        Task DeleteProduct(string id);
    }
}
