using Euler.Library;

internal class Problem_22 : ProblemBase
{
    string names = File.ReadAllText("p022_names.txt");
    int result = 0;
    public Problem_22()
    {
        title = "Problem 22 - Names scores";
        description = "Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).\r\nIf d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.";
        question = "Evaluate the sum of all the amicable numbers under 10000.";
    }
    public override void Solve()
    {
        Console.WriteLine(names.Length);
    }

    public override void DisplayResult()
    {
        DisplayResult($"The total of all the name scores in the file: {result}");
    }
}