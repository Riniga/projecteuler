using System;
using System.Collections.Generic;

namespace Euler.Library
{
    public class SuperSummer
    {
        public static long Sum(List<long> numbers)
        {
            var result = 0l;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }

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
            var length = MaxLength(numbers);
            PadNumbers(numbers, length);

            string result = "";
            int rest = 0;
            for (int i = length-1; i >= 0; i--)
            {
                int sum = rest;
                foreach (var number in numbers) sum += number[i] - 48;
                rest = sum / 10;
                result = (sum % 10) + result;
            }
            return (rest + result).TrimStart('0');
        }

        private static void PadNumbers(string[] numbers, int length)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i].PadLeft(length, '0');
            }
        }

        private static int MaxLength(string[] numbers)
        {
            int maxLength = 0;
            foreach (var number in numbers)
                if (number.Length > maxLength) maxLength=number.Length;
            return maxLength;
        }
    }
}
