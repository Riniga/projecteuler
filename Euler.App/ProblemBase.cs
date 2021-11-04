using Euler.Library;
abstract class ProblemBase : IProblem
{
    protected TimeSpan executionTime;
    protected string title;
    protected string description;
    protected string question;

    public void DisplayResult(string resultString)
    {
        Console.WriteLine("Problem 9 - Special Pythagorean triplet");
        Console.WriteLine("A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a^2+b^2=c^2");
        Console.WriteLine("There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.? ");
        Console.WriteLine();
        Console.WriteLine(resultString);
        Console.WriteLine("Execution time: " + executionTime);
    }

    public abstract void DisplayResult();
    public abstract void Solve();
    
}