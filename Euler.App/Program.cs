using Euler.App;

var problems= new Problems();
var currentProblem = problems.GetProblem(10);

currentProblem.Solve();
currentProblem.DisplayResult();