using Data;
using System.Collections.Generic;

namespace TestAPI.Models
{
    public interface IProductModel 
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
