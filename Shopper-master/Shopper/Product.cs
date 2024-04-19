namespace Shopper
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }

        public Product(string name, string description, decimal price, string color)
        {
            Name = name;
            Description = description;
            Price = price;
            Color = color;
        }
    }
}
