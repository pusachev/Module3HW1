using System;
using Module3HW1.Entity;
namespace Module3HW1.Factory
{
    public interface IProductFactory
    {
        IProduct Create(string name, string sku, decimal price, double qty);
    }
}
