using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WebShopDemo.Core.Contracts;
using WebShopDemo.Core.Models;

namespace WebShopDemo.Core.Services
{
    /// <summary>
    /// Manipulates product data
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IConfiguration config;

        /// <summary>
        /// IoC 
        /// </summary>
        /// <param name="config">Application configuration</param>
        public ProductService(IConfiguration _config)
        {
            this.config = _config;
        }

        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns>List of products</returns>
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            string dataPath = config.GetSection("DataFiles:Products").Value;
            string data = await File.ReadAllTextAsync(dataPath);

            return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(data);
        }
    }
}
