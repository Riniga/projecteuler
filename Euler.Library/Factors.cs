namespace Euler.Library
{
    public class Factors
    {
        public static List<long> GetFactorsFor(long number)
        {
            var factors = new List<long>();
            if (number < 1) return factors;
            factors.Add(1);
            if (number == 1) return factors;

            var max = (int)Math.Sqrt(number);
            for (var i = 2; i <= max; i++)
            {
                if (number % i != 0) continue;
                factors.Add(i);
                factors.Add(number / i);
            }
            factors.Add(number);
            return factors;
        }

        public static List<long> GetPrimeFactorsFor(long number)
        {
            if (number < 2) return new List<long>();
            if (number == 3) return new List<long> { 3 };

            var factors = new List<long>();
            var max = (int)Math.Sqrt(number);

            for (var i = 3; i <= max; i = Prime.NextPrimeNumber(i))
            {
                if (number % i != 0) continue;
                factors.Add(i);
            }

            return factors;
        }

        
    }
}