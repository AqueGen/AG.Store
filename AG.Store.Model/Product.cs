namespace AG.Store.Model
{
    public class Product
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public byte[] ImageData { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
    }
}