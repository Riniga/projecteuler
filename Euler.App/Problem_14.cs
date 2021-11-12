using Euler.Library;

internal class Problem_14 : ProblemBase
{
    private KeyValuePair<int, int> longest =  new KeyValuePair<int, int>();

    public Problem_14()
    {
        title = "Problem 14 - Longest Collatz sequence";
        description = "The following iterative sequence is defined for the set of positive integers: n → n / 2(n is even) n → 3n + 1(n is odd)";
        question = "Which starting number, under one million, produces the longest chain??";
    }

    public override void Solve()
    {
        DateTime start = DateTime.Now;
        
        for(int i =1; i<1000000; i++)
        { 
            int len=ChainLength(i);
            if (longest.Value < len) 
                longest= new KeyValuePair<int, int>(i, len);
        }
        executionTime = DateTime.Now - start;
    }
    public override void DisplayResult()
    {
        DisplayResult($"The longest chain is for value {longest.Key} and has {longest.Value} elements in the chain");
    }
    private int ChainLength(long number)
    {
        int count =0;
        while (number != 1)
        {
            if (number % 2 == 0) number = number / 2;
            else number = 3 * number + 1;
            count++;
        }
        return count;
    }
}