using Data;
using System.Collections.Generic;

namespace TestApi.Models
{
    public class ProductModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
