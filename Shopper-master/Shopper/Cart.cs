namespace Shopper
{
    public class Cart
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal Value { get; set; }

        public void Add(Product product)
        {
            try
            {
                Products.Add(product);
                Recalculate();
            }
            catch (Exception)
            {
                throw new ArgumentNullException(nameof(product));
            }
        }

        public void Remove(int productNumber)
        {
            var productToRemove = Products[productNumber - 1];
            Products.Remove(productToRemove);
            Recalculate();
        }

        private void Recalculate()
        {
            Value = 0;

            foreach (Product product in Products)
            {
                //Value = Value + product.Price;
                Value += product.Price;
            }
        }
    }
}