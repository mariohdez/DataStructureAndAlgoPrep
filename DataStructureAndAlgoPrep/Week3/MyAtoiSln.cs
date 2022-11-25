using System;
namespace DataStructureAndAlgoPrep.Week3
{
    public class MyAtoiSln
    {
        public int MyAtoi(string s)
        {
            int integer = 0;
            int i = 0;
            int len = s.Length;
            bool negative = false;
            int digit = 0;

            while (i < len && char.IsWhiteSpace(s[i])) i++;

            if (i < len && (s[i] == '+' || s[i] == '-'))
            {
                negative = s[i] == '-';
                i++;
            }

            while (i < len && char.IsDigit(s[i]))
            {
                digit = s[i] - '0';

                if ((integer > int.MaxValue / 10) ||
                    (integer == int.MaxValue / 10 && digit > int.MaxValue % 10))
                {
                    return negative ? int.MinValue : int.MaxValue;
                }

                integer = (integer * 10) + digit;
                i++;
            }

            return negative ? integer * -1 : integer;
        }
    }
}
