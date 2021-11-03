List<IProblem> problems = new List<IProblem>();
problems.Add(new Problem_1(1000));
problems.Add(new Problem_2(4000000));
problems.Add(new Problem_3(600851475143));
problems.Add(new Problem_4());
problems.Add(new Problem_5());
problems.Add(new Problem_6(100));


int problemId = 5;
problems[problemId].Solve();
problems[problemId].DisplayResult();



