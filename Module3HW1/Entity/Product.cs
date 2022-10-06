using System;
namespace Module3HW1.Entity
{
    public class Product : IProduct
    {
        public Product(
            string name,
            string sku,
            decimal price,
            double qty = 0.0)
        {
            Name = name;
            Sku = sku;
            Price = price;
            Qty = qty;
        }

        public string Name { get; private set; }

        public string Sku { get; private set; }

        public decimal Price { get; private set; }

        public double Qty { get; private set; }
    }
}
