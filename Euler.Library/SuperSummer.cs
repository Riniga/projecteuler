using System;
using System.Collections.Generic;

namespace Euler.Library
{
    public class SuperSummer
    {
        public static int SumEven(List<int> numbers)
        {
            var result=0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0) result += number;
            }
            return result;
        }
    }
}
