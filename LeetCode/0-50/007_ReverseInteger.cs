using System;

namespace LeetCode._0_50
{
    public class _007_ReverseInteger
    {
        public int Reverse(int x)
        {
            var stringValue = x.ToString();
            var reversedString = ReverseIntegerString(stringValue);

            return int.TryParse(reversedString, out var result) ? result : 0;
        }

        private static string ReverseIntegerString(string s)
        {
            char[] charArray = s.ToCharArray();
            if (charArray[0] == '-')
            {
                Array.Reverse(charArray, 1, charArray.Length - 1);
            }
            else
            {
                Array.Reverse(charArray);
            }

            return new string(charArray);
        }

        /*
        // With Math
        public int Reverse(int x) {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > int.MaxValue/10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                if (rev < int.MinValue/10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }

            return rev;
        }

        */

        /* 
        // With symbols
        public int Reverse(int x) {
            var stringValue = x.ToString();
            var reversedString = ReverseIntegerString(stringValue);

            return int.TryParse(reversedString, out var result) ? result : 0;
        }

        private static string ReverseIntegerString(string s)
        {
            char[] charArray = s.ToCharArray();
            if (charArray[0] == '-')
            {
                Array.Reverse(charArray, 1, charArray.Length - 1);
            }
            else
            {
                Array.Reverse(charArray);
            }

            return new string(charArray);
        }
        */
    }
}