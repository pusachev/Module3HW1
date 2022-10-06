using System;
namespace Module3HW1.Comparer
{
    public class ReverseIntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }

            return x > y ? -1 : 1;
        }
    }
}
