using Euler.Library;

internal class Problem_20 : ProblemBase
{
    private int result=0;
    public Problem_20()
    {
        title = "Problem 20 - Factorial digit sum";
        description = "n! means n × (n − 1) × ... × 3 × 2 × 1 For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800, and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.";
        question = "Find the sum of the digits in the number 100!";
    }
    public override void Solve()
    {
        var factorial = Factorial(100).TrimStart('0');
        result = factorial.ToString().SumOfDigits();
    }

    private string Factorial(int number)
    {
        if (number > 1) return number.ToString().MultiplyWith(Factorial(number - 1));
        return "1";
    }

    public override void DisplayResult()
    {
        DisplayResult($"Sum of the digits are:: {result}");
    }
}