﻿using Euler.Library;

internal class Problem_12 : ProblemBase
{
    private long trianglenNumber=1;
    private int divisors;
    
    public Problem_12(int divisors)
    {
        this.divisors = divisors;
        title = "Problem 12 - Highly divisible triangular number";
        description = "The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28";
        question = "What is the value of the first triangle number to have over five hundred divisors?";
    }

    public override void Solve()
    {
        DateTime start = DateTime.Now;
        int i =2;
        while(true)
        { 
            trianglenNumber += i++;
            var factors = Factors.GetFactorsFor(trianglenNumber);
            if (factors.Count > divisors) break;
        }
        executionTime = DateTime.Now - start;
    }

    public override void DisplayResult()
    {
        DisplayResult($"The first triangle number with {divisors} divisors is {trianglenNumber.ToString("n", NumberFormat.Integer)} " );
    }
    
}