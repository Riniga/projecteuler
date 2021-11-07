using Euler.Library;

internal class Problem_1 : ProblemBase
{
    private int result;
    private TimeSpan executionTime;
    private int max;

    public Problem_1() : this(1000) {}

    public Problem_1(int max)
    {
        this.max = max;
    }

    public override void Solve()
    {
        DateTime start= DateTime.Now;

        var sum = 0;
        for (var i = 3; i < max; i++)
        {
            var factors = Factors.GetFactorsFor(i);
            if (factors.Contains(3) || factors.Contains(5)) sum += i;
        }
        result = sum;
        executionTime = DateTime.Now - start;
    }

    public override void DisplayResult()
    {
        Console.WriteLine("Problem 1, Multiples of 3 and 5");
        Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.");
        Console.WriteLine("\r\nThe sum of all numbers with factors 3 or 5 is: " + result);
        Console.WriteLine("Execution time: " + executionTime);

    }

}