using Data;
using System.Collections.Generic;
using TestAPI.Models;

namespace TestApi.Models
{
    public class ProductModel : IProductModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
