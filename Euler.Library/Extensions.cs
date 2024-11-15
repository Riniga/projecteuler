﻿namespace Euler.Library
{
    public static class Extensions
    {
        public static bool IsDividableBy(this int i, List<int> dividers)
        {
            foreach (var divider in dividers)
            {
                if (i % divider != 0) return false;
                    
            }
            return true;
        }
        public static bool IsDividableBy(this long i, List<int> dividers)
        {
            foreach (var divider in dividers)
            {
                if (i % divider != 0) return false;
            }
            return true;
        }
        public static string MultiplyWith(this string term1, string term2)
        {
            var partials = new List<string>();
            for (int t2i = term2.Length - 1; t2i >= 0; t2i--)
            {
                var partial = string.Empty.PadRight(term2.Length-t2i-1 , '0');
                var rest = 0;
                for (int t1i = term1.Length - 1; t1i >= 0; t1i--)
                {
                    var number = ((term2[t2i] - 48) * (term1[t1i] - 48))+rest;
                    partial = (number%10) + partial;
                    rest = (number / 10);
                }
                partial = rest + partial;
                partials.Add(partial);
            }
            return SuperSummer.StringSummer(partials.OrderBy(s=>s.Length).Reverse().ToArray());
        }
        public static int SumOfDigits(this string number)
        {
            int sum = 0;
            foreach(char c in number)
            {
                sum += c-48;
            } 
            return sum;
        }
        public static double SumOfDigits(this double number)
        {
            double sum = 0;
            do
            {
                sum += number % 10;
                number = number / 10;
            } while (number > 0);
            return sum;
        }

        public static string ToWords(this int number)
        {
            if (number < 0) return "Negative number not supported, yet";
            else if (number < 20) return first[number];
            else if (number < 100) return tenth[number / 10 - 2] + ((number % 10 == 0) ? "" : "-" + first[number % 10]);
            else if (number < 1000)
            {
                string result = hundreds[number / 100 - 1] ;
                int rest = number % 100;
                if (rest > 0) result += " and "  + rest.ToWords();
                return result;
            }
            else if (number < 10000)
            {
                string result = thousend[number / 1000 - 1];
                int rest = number % 1000;
                if (rest > 0) result += " and " + rest.ToWords();
                return result;
            }
            else return "Too large";
        }

        private static string[] first = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static string[] tenth= new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        private static string[] hundreds = new string[] { "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };
        private static string[] thousend = new string[] { "one thousand", "two thousand", "three thousand", "four thousand", "five thousand", "six thousand", "seven thousand", "eight thousand", "nine thousand" };

    }
}
