namespace Euler.Library
{
    public class Fibonacci
    {
        public static List<int> FibonacciNumber(int max)
        {
            var numbers = new List<int>();
            if (max <= 1) return numbers;
            
            int next = 1;
            numbers.Add(next);
            if (max == 1) return numbers;
            
            int previous = 1;
            next = next+previous;

           
            while (next < max)
            {
                numbers.Add(next);
                var temp = next;
                next = next + previous;
                previous = temp;

            }
            return numbers;
        }
    }
}
