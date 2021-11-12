using Euler.Library;

internal class Problem_16 : ProblemBase
{
    private int _base;
    private int _exponent;
    private int result;

    public Problem_16() : this(2, 1000) { }
    public Problem_16(int _base, int _exponent)
    {
        this._base = _base;
        this._exponent = _exponent;
        title = "Problem 16 - Power digit sum";
        description = "2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.";
        question = "What is the sum of the digits of the number 2^1000?";
    }

    public override void Solve()
    {
        DateTime start = DateTime.Now;
        var pow1 = Math.Pow(_base, _exponent);
        string sum = "1";
        for (int i = 0; i < _exponent; i++)
        {
            sum = SuperSummer.StringSummer(new string[] {sum, sum });
        }
        result = sum.SumOfDigits();
        executionTime = DateTime.Now - start;
    }

    public override void DisplayResult()
    {
        DisplayResult($"the sum of the digits of the number {_base}^{_exponent} is {result}");
    }
}