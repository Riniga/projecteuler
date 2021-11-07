using Euler.Library;
public abstract class ProblemBase : IProblem
{
    protected TimeSpan executionTime;
    public string title;
    protected string description;
    protected string question;

    public void DisplayResult(string resultString)
    {
        Console.WriteLine(title);
        Console.WriteLine(description);
        Console.WriteLine(question);
        Console.WriteLine();
        Console.WriteLine(resultString);
        Console.WriteLine("Execution time: " + executionTime);
    }
    public virtual string GetTitle()
    {
        return title;
    }

    public abstract void DisplayResult();
    public abstract void Solve();
    
}