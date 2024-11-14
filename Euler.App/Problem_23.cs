using Euler.Library;
using System;
using System.Linq;

internal class Problem_26 : ProblemBase
{
    
    long result = 0;
    
    public Problem_26()
    {
        
        title = "Problem 26";
        description = "A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given";
        question = "Find the value of d<1000 for witch 1/d contain the longest recurring cycle in its decimal fraction part";
    }
    public override void Solve()
    {
        
        long current = (long)1/11;
        result = current;
    }
    public override void DisplayResult()
    {
        DisplayResult($"The total of all the name scores in the file: {result}");
    }
}