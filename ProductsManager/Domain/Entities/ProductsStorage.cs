namespace ProductsManager.Domain.Entities
{
    public class ProductsStorage
    {
        public string UserId { get; set; }
        public List<Product> Products { get; set; }
    }
}
