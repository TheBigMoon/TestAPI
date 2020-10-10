namespace Data
{
    public interface IProductBase
    {
        public int CategoryId { get; set; }
    }

    public class Product : IModelBase, IProductBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
