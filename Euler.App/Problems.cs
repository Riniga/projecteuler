namespace Euler.App
{
    public class Problems
    {
        private List<IProblem> problems = new List<IProblem>();
        public Problems()
        {
            problems.Add(new Problem_1(1000));
            problems.Add(new Problem_2(4000000));
            problems.Add(new Problem_3(600851475143));
            problems.Add(new Problem_4());
            problems.Add(new Problem_5());
            problems.Add(new Problem_6(100));
            problems.Add(new Problem_7(10001));
            problems.Add(new Problem_8(13));
        }

        public IProblem GetProblem(int number)
        { 
            return problems[number-1];
        }
    }
}
