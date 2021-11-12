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
        public static int SumOfDigits(this string number)
        {
            int sum = 0;
            foreach(char c in number)
            {
                sum += c-48;
            } 
            return sum;
        }
        public static double SumOfDigits(this double number)
        {
            double sum = 0;
            do
            {
                sum += number % 10;
                number = number / 10;
            } while (number > 0);
            return sum;
        }
    }
}
