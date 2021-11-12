namespace Euler.Library
{
    public class Pascal
    {
        public static List<List<double>> Triangle(int rows)
        {
            var result = new List<List<double>>();
            for (int i = 0; i < rows; i++)
            { 
                var row = new List<double>();
                for (int j = 0; j <= i; j++) 
                {
                    double sum = (j == 0 || j == i)? 1: result[i-1][j-1] + result[i-1][j];
                    row.Add(sum);
                }
                result.Add(row);
            }
            return result;
        }
    }
}
