using System;
using Module3HW1.Entity;
namespace Module3HW1.Comparer
{
    public class ProductPriceComparer : IComparer<IProduct>
    {
        public int Compare(IProduct? x, IProduct? y)
        {
            if (x == null || y == null)
            {
                return y == null ? 1 : -1;
            }

            if (x.Price == y.Price)
            {
                return 0;
            }

            return x.Price > y.Price ? 1 : -1;
        }
    }
}
