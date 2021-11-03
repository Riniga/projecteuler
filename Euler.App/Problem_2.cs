﻿using Euler.Library;

internal class Problem_2 : IProblem
{
    private int result;
    private TimeSpan executionTime;
    private int max;

    public Problem_2(int max)
    {
        this.max = max;
    }

    public void Solve()
    {
        DateTime start= DateTime.Now;
        var numbers = Fibonacci.FibonacciNumber(max);
        result = SuperSummer.SumEven(numbers);
        executionTime = DateTime.Now - start;
    }

    public void DisplayResult()
    {
        Console.WriteLine("Problem 2 - Even Fibonacci numbers");
        Console.WriteLine("Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.");
        Console.WriteLine("\r\nThe sum of all event numbers in the fibonacci series less than 4 million is: " + result);
        Console.WriteLine("Execution time: " + executionTime);
    }

}