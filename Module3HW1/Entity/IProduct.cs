using System;
namespace Module3HW1.Entity
{
    public interface IProduct
    {
        public string Name { get; }

        public string Sku { get; }

        public decimal Price { get; }

        public double Qty { get; }
    }
}
