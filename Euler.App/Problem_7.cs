using Euler.Library;

internal class Problem_7 : IProblem
{
    private int result;
    private TimeSpan executionTime;
    private int count;

    public Problem_7(int count)
    {
        this.count = count;
    }

    public void Solve()
    {
        DateTime start= DateTime.Now;
        
        for (int i = 1; i <= count; i++) 
            result=Prime.NextPrimeNumber(result) ;
        
        executionTime = DateTime.Now - start;
    }

    public void DisplayResult()
    {
        Console.WriteLine("Problem 7 - 10001st prime");
        Console.WriteLine("By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.");
        Console.WriteLine("What is the 10 001st prime number?");

        Console.WriteLine("\r\nThe 10 001st prime number is: " + result);
        Console.WriteLine("Execution time: " + executionTime);

    }

}