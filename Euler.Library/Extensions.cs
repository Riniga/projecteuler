namespace Euler.Library
{
    public static class Extensions
    {
        public static bool IsDividableBy(this int i, List<int> dividers)
        {
            foreach (var divider in dividers)
            {
                if (i % divider != 0) return false;
                    
            }
            return true;
        }
        public static bool IsDividableBy(this long i, List<int> dividers)
        {
            foreach (var divider in dividers)
            {
                if (i % divider != 0) return false;
            }
            return true;
        }
    }
}
