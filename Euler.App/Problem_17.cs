using Euler.Library;

internal class Problem_17 : ProblemBase
{
    private int letters;
    private int number;
    

    public Problem_17() : this(1000) { }
    public Problem_17(int number)
    {
        this.number = number;
        title = "Problem 17 - Number letter counts";
        description = "If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.";
        question = "If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?";
    }

    public override void Solve()
    {
        DateTime start = DateTime.Now;
        for (int i = 1; i <= number; i++)
        {
            string result = i.ToWords();
            Console.WriteLine($"The number {i} as words is {result}");
            letters+= result.Replace("-", "").Replace(" ", "").Count();
        }
        
        executionTime = DateTime.Now - start;
    }

    public override void DisplayResult()
    {
        DisplayResult($"Number of charactes {letters}");
    }
}