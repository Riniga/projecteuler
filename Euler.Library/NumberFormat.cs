using System.Globalization;

namespace Euler.Library
{
    public class NumberFormat
    {
        public static NumberFormatInfo Integer
        {
            get { 
                var format = new CultureInfo("sv-SE", false).NumberFormat;
                format.NumberDecimalDigits = 0;
                return format;
            }
        }
    }
}
