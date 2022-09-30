using ProductsManager.Domain.Enums;

namespace ProductsManager.Domain.Entities
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Category { get; set; }
        public Unit Unit { get; set; }
        public decimal Count { get; set; }
    }
}
