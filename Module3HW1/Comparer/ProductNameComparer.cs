using System;
using Module3HW1.Entity;
namespace Module3HW1.Comparer
{
    public class ProductNameComparer : IComparer<IProduct>
    {
        private readonly StringComparer _comparer = StringComparer.CurrentCulture;

        public int Compare(IProduct? x, IProduct? y)
        {
            if (x == null || y == null)
            {
                return y == null ? 1 : -1;
            }

            return _comparer.Compare(x.Name, y.Name);
        }
    }
}
