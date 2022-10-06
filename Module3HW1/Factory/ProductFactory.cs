using System;
using Module3HW1.Entity;
namespace Module3HW1.Factory
{
    public class ProductFactory : IProductFactory
    {
        public IProduct Create(
            string name,
            string sku,
            decimal price,
            double qty)
        {
            return new Product(name, sku, price, qty);
        }
    }
}
