using Euler.Library;

internal class Problem_21 : ProblemBase
{
    private List<long> result= new List<long>();
    public Problem_21()
    {
        title = "Problem 21 - Amicable numbers";
        description = "Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).\r\nIf d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.";
        question = "Evaluate the sum of all the amicable numbers under 10000.";
    }
    public override void Solve()
    {
        for (long i=1; i<10000; i++)
        {
            var iDivisors = GetDevisors(i);
            var j = SuperSummer.Sum(iDivisors);
            var jDivisors = GetDevisors(j);
            var i2 = SuperSummer.Sum(jDivisors);
            if (i!=j && i2 == i) result.Add(i);
        }
    }

    private List<long> GetDevisors(long number)
    {
        var factors = Factors.GetFactorsFor(number);
        factors.Remove(number);
        return factors;
    }
    public override void DisplayResult()
    {
        DisplayResult($"Sum of the amiclble numbers are: {SuperSummer.Sum(result)}");
    }
}