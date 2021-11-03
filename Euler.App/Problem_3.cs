using Euler.Library;

internal class Problem_3 : IProblem
{
    private List<long> result;
    private TimeSpan executionTime;
    private long number;

    public Problem_3(long number)
    {
        this.number = number;
        result = new List<long>();
    }

    public void Solve()
    {
        DateTime start= DateTime.Now;
        result = Factors.GetPrimeFactorsFor(number);
        executionTime = DateTime.Now - start;
    }

    public void DisplayResult()
    {
        Console.WriteLine("Problem 3 - Largest prime factor");
        Console.WriteLine("The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number " + number + " ?");
        Console.WriteLine("\r\nThe larges primefactor for "+ number + " is: " + result[result.Count - 1]);
        Console.WriteLine("Execution time: " + executionTime);

    }

}