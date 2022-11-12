using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class DigitPalindrome
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x%10 == 0 && x != 0))
            {
                return false;
            }

            var reversedInt = 0;

            while (x > reversedInt)
            {
                var lastDigit = x % 10;
                reversedInt = (reversedInt * 10) + lastDigit;
                x = x / 10;
            }

            return x == reversedInt || (x == (reversedInt / 10));
        }
    }
}
