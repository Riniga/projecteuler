using Euler.Library;
using System.Globalization;

internal class Problem_9 : ProblemBase
{
    private int[] result = new int[3];
    private int number;
    public Problem_9() : this(1000) { }
    public Problem_9(int number)
    {
        this.number = number;
        title = "Problem 9 - Special Pythagorean triplet";
        description = "A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a^2+b^2=c^2";
        question = "There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.? ";
    }

    public override void Solve()
    {
        DateTime start= DateTime.Now;
        int maxA = number / 3;
        int a = 3;
        int b;
        double c=5;
        while (true)
        {
            b = ++a;
            if (a > maxA) break;
            while (true)
            {
                b++;
                c = Math.Sqrt(a * a + b * b);
                if (a + b + c >= number) break;
            }
            if (a + b + c == number) break;
        }
        result = new int[] { a,b, (int)c };
        executionTime = DateTime.Now - start;
    }

    public override void DisplayResult() 
    {
        
        DisplayResult($"The triplet product of {result[0]},{result[1]},{result[2]}, is: " + (result[0]* result[1]* result[2]).ToString("n", NumberFormat.Integer));
    }

}