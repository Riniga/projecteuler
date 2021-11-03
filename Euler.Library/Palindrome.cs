namespace Euler.Library
{
    public class Palindrome
    {
        public static bool IsPalindrome(int number)
        {
            var numberString = number.ToString();
            var length = numberString.Length;
            if (length % 2 != 0) return false;
            for (int i = 0; i < length / 2; i++)
                if (numberString[i] != numberString[length - i - 1])
                    return false;
            return true;
        }
    }
}
