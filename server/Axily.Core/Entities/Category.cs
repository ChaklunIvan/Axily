namespace Axily.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual IEnumerable<Product>? Products { get; set; }
    }
}
