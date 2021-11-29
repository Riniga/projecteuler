internal class Problem_19 : ProblemBase
{
    private int result=0;
    public Problem_19()
    {
        title = "Problem 19 - Antal Söndagar";
        description = "By starting at the top of the triangle below and moving to adjacent numbers on the row below";
        question = "Find the maximum total from top to bottom of the triangle.";
    }
    public override void Solve()
    {
        int weekday = -1;
        for (int year = 1900; year <= 2000; year++)
        {
            for (int month = 1; month <= 12; month++)
            {
                for (int day = 1; day <= 31; day++)
                {
                    weekday = ++weekday % 7;
                    if (month == 2 && !isLeapYear(year) && day == 28) day = 32;
                    else if (month == 2 && day == 29) day = 32;
                    else if (day == 30 && (month == 4 || month == 6 || month == 9 || month == 11)) day = 32;
                    if (year>1900 && day == 1 && weekday == 6) result++; 
                }
            }
        }
    }

    private bool isLeapYear(int year)
    {
        if (year % 4 == 0 && (!(year % 100 == 0) || year % 400 == 0)) return true;
        return false;
    }

    public override void DisplayResult()
    {
        DisplayResult($"Antal söndagar: {result}");
    }
}