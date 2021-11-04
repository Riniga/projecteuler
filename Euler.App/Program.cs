using Euler.App;

var problems= new Problems();
var currentProblem = problems.GetProblem(12);

currentProblem.Solve();
currentProblem.DisplayResult();