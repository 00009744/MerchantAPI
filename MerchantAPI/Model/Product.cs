namespace MerchantAPI.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
    }
}
