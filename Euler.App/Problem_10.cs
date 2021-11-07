using Euler.Library;

internal class Problem_10 : ProblemBase
{
    private double result;
    private int number;

    public Problem_10() : this(2000000) { }
    public Problem_10(int number)
    {
        this.number = number;
        title = "Problem 10 - Summation of primes";
        description = "The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.";
        question = "Find the sum of all the primes below two million.";
    }

    public override void Solve()
    {
        DateTime start= DateTime.Now;
        List<int> primes = new List<int>();
        int currentPrime = 2;
        while (currentPrime < number)
        {
            primes.Add(currentPrime);
            currentPrime = Prime.NextPrimeNumber(currentPrime);
        }
        foreach (var prime in primes)
        {
            result += prime;
        }
        executionTime = DateTime.Now - start;
    }

    public override void DisplayResult() 
    {
        DisplayResult($"The sum of all primes is: " + result.ToString("n", NumberFormat.Integer));
    }

}