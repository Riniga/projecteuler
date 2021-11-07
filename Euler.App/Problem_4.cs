using Euler.Library;

internal class Problem_4 : ProblemBase
{
    private int result;
    private TimeSpan executionTime;
    public Problem_4() { }

    public override void Solve()
    {
        DateTime start= DateTime.Now;
        var largest = 0;
        for (var i = 999; i > 99; i--)
            for (var j = 999; j > 99; j--)
            {
                var product = i * j;
                if (Palindrome.IsPalindrome(product)) if (largest < product) largest = product;
            }
        result= largest;
        executionTime = DateTime.Now - start;
    }

    public override void DisplayResult()
    {
        Console.WriteLine("Problem 4 - Largest palindrome product");
        Console.WriteLine("A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99. Find the largest palindrome made from the product of two 3-digit numbers. ");
        Console.WriteLine("\r\nThe larges palindrome is: " + result);
        Console.WriteLine("Execution time: " + executionTime);
    }

}