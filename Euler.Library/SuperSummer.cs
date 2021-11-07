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

        public static string StringSummer(string[] numbers)
        {
            string result = "";
            int rest = 0;
            for (int i = 49; i >= 0; i--)
            {
                int sum = rest;
                foreach (var number in numbers) sum += number[i] - 48;
                rest = sum / 10;
                result = (sum % 10) + result;
            }
            return rest + result;
        }

    }
}
