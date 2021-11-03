using Euler.Library;

internal class Problem_5 : IProblem
{
    private long result;
    private TimeSpan executionTime;

    public Problem_5()
    {
    }

    public void Solve()
    {
        DateTime start= DateTime.Now;
        var dividers = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        long i = 20;
        while (!i.IsDividableBy(dividers)) i += 20;
        result = i;
        executionTime = DateTime.Now - start;
    }

    public void DisplayResult()
    {
        Console.WriteLine("Problem 5 - Smallest multiple");
        Console.WriteLine("2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.\r\nWhat is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");
        Console.WriteLine("\r\nThe smallest number is: " + result);
        Console.WriteLine("Execution time: " + executionTime);
    }
}