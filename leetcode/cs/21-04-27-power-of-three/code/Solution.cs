using System;

namespace code
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            // We quickly eliminate if its not a positive number
            if (n <= 0)
            {
                return false;
            }
            
            if (n == 1)
            {
                return true;
            }
            
            // We quickly eliminate if its not a multiple of 3.
            if(IsMultipleOfThree(n) == false)
            {
                return false;
            }
            
            var digitString = n.ToString();
            var l = digitString.Length;
            var x0 = 2 * l;
            var x1 = x0 - 1;

            var proof1 = n / Math.Pow(3.0, x0);
            var proof2 = n / Math.Pow(3.0, x1);

            return (proof1 == 1d || proof2 == 1d);
        }

        public static bool IsSingleDigitMultiple(int n)
        {
            return (n == 9 || n == 6 || n == 3);
        }

        public static int ConvertToInteger(char i)
        {
            return (int) char.GetNumericValue(i);
        }
        
        public static bool IsMultipleOfThree(int n)
        {
            var digitString = n.ToString().ToCharArray();

            if (digitString.Length == 1)
            {
                return IsSingleDigitMultiple(ConvertToInteger(digitString[0]));
            }
            
            n = SumOfDigits(digitString);

            return IsMultipleOfThree(n);
        }

        public static int SumOfDigits(char[] digitString)
        {
            var sum = 0;

            foreach (var t in digitString)
            {
                var digit = ConvertToInteger(t);

                if (digit == -1)
                {
                    throw new ArgumentOutOfRangeException(nameof(t), "The character is not a valid numeric value");
                }
                sum += ConvertToInteger(t);
            }

            return sum;
        }
    }
}