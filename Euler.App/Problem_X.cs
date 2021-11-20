using Euler.Library;
using Euler.Library.Graph;

internal class Problem_X : ProblemBase
{
    public Problem_X()
    {
        enable = false;
        title = "Problem X - Just messing around with graphs, good stuff";
        description = "";
        question = "";
    }

    public override void Solve()
    {
        DateTime start = DateTime.Now;
        
        Graph2D roadmap = new Graph2D(4,200,100);
        Console.WriteLine(roadmap.ToString());
        Console.WriteLine("=============");
        var shortestRoute = PathFinder.ShortestPath(roadmap);
        Console.WriteLine(shortestRoute.ToString());
        Console.WriteLine("=============");
        Console.WriteLine($"Length is: " + shortestRoute.Length());
        PathFinder.RandomSwap(1000, roadmap);
        Console.WriteLine($"Length is: " + shortestRoute.Length());
        Console.WriteLine("=============");

        executionTime = DateTime.Now - start;
    }

    public override void DisplayResult()
    {
        
    }
}