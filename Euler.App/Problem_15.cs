using Euler.Library;

internal class Problem_15 : ProblemBase
{
    private int size;
    
    private double result;

    public Problem_15() : this(20) { }
    public Problem_15(int size)
    {
        this.size = size;
        title = "Problem 15 - Lattice paths";
        description = "Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.";
        question = "How many such routes are there through a 20×20 grid?";
    }

    public override void Solve()
    {
        DateTime start = DateTime.Now;
        var paths =  Pascal.Triangle(size*2+1);
        var lastrow = paths.Last();
        result = lastrow[lastrow.Count / 2];
        executionTime = DateTime.Now - start;
    }

    public override void DisplayResult()
    {
        DisplayResult($"Number of paths in a {size}x{size} grid is {result}");
    }
}