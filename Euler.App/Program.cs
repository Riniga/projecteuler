﻿using Euler.App;

var problems= new Problems();
var currentProblem = problems.GetProblem(8);

currentProblem.Solve();
currentProblem.DisplayResult();