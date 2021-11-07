using System.Reflection;
using System.Text.RegularExpressions;

namespace Euler.App
{
    public class Problems
    {
        private List<ProblemBase> problems = new List<ProblemBase>();
        public Problems()
        {
            var types = Assembly.GetAssembly(typeof(ProblemBase))?.GetTypes();
            if(types != null)
            { 
                types = types.Where(type=> type.FullName.Contains("Problem_")).OrderBy(type => Regex.Replace(type.FullName, @"\d+", type => type.Value.PadLeft(4, '0'))).ToArray();
                foreach (var type in types)
                {
                    var problem = Activator.CreateInstance(type);
                    if (problem != null) problems.Add((ProblemBase)problem);
                }
            }
        }

        public ProblemBase GetProblem(int number)
        { 
            return problems[number-1];
        }

        internal ProblemBase GetLastProblem()
        {
            return GetProblem(problems.Count);
        }
    }
}
