using Euler.Library;
using System;
using System.Linq;

internal class Problem_23 : ProblemBase
{
    
    long result = 0;
    public Problem_23()
    {
        title = "Problem 23 - ...";
        description = "Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.";
        question = "What is the total of all the name scores in the file?";
    }
    public override void Solve()
    {

    }
    public override void DisplayResult()
    {
        DisplayResult($"The total of all the name scores in the file: {result}");
    }
}