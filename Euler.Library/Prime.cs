namespace Euler.Library
{
    public class Prime
    {
        public static int NextPrimeNumber(int number)
        {
            number += (number % 2 == 0) ? 1 : 2;
            if (IsPrimeNumber(number)) return number;

            return NextPrimeNumber(number);
        }

        private static bool IsPrimeNumber(int number)
        {
            int max = (int)Math.Sqrt(number);
            for (int i = 3; i <= max; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}