using Euler.Library;

internal class Problem_6 : IProblem
{
    private int result;
    private TimeSpan executionTime;
    private int count;

    public Problem_6(int count)
    {
        this.count = count;
    }

    public void Solve()
    {
        DateTime start= DateTime.Now;
        int sumofsqueres = 0;
        int sum = 0;
        for (int i = 1; i <= count; i++) sumofsqueres += i*i;
        for (int i = 1; i <= count; i++) sum += i;
        result = (sum*sum) - sumofsqueres;
        executionTime = DateTime.Now - start;
    }

    public void DisplayResult()
    {
        Console.WriteLine("Problem 6 - Sum square difference");
        Console.WriteLine("The sum of the squares of the first ten natural numbers is 385");
        Console.WriteLine("The square of the sum of the first ten natural numbers is 3025");
        Console.WriteLine("Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025-385=2640");
        Console.WriteLine("Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.");

        Console.WriteLine("\r\nThe difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is: " + result);
        Console.WriteLine("Execution time: " + executionTime);

    }

}