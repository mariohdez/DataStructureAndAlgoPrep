using System;
using System.Linq;
using System.Text;

namespace DataStructureAndAlgoPrep.Week1
{
    public class AddBinarySln
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder resultStringBuilder = new StringBuilder();
            int carry = 0;
            int bPtr = b.Length - 1;
            int aPtr = a.Length - 1;

            while (aPtr >= 0 && bPtr >= 0)
            {

                var aInt = ((int)a[aPtr] - '0');
                var bInt = ((int)b[bPtr] - '0');

                var tempRes = aInt + bInt + carry;

                if (tempRes == 2)
                {
                    // write 0, carry => 1
                    resultStringBuilder.Append("0");
                    carry = 1;

                }
                else if (tempRes == 3)
                {
                    // write 1, carry => 1
                    resultStringBuilder.Append("1");
                    carry = 1;
                }
                else
                {
                    // write result, carry 0
                    carry = 0;
                    resultStringBuilder.Append(tempRes);
                }

                aPtr--;
                bPtr--;
            }

            while (aPtr >= 0)
            {
                var tempRes = ((int)a[aPtr] - '0') + carry;

                if (tempRes == 2)
                {
                    // write 0, carry => 1
                    resultStringBuilder.Append("0");
                    carry = 1;

                }
                else if (tempRes == 3)
                {
                    // write 1, carry => 1
                    resultStringBuilder.Append("1");
                    carry = 1;
                }
                else
                {
                    // write result, carry 0
                    carry = 0;
                    resultStringBuilder.Append(tempRes);
                }

                aPtr--;
            }

            while (bPtr >= 0)
            {
                var tempRes = ((int)b[bPtr] - '0') + carry;

                if (tempRes == 2)
                {
                    // write 0, carry => 1
                    resultStringBuilder.Append("0");
                    carry = 1;

                }
                else if (tempRes == 3)
                {
                    // write 1, carry => 1
                    resultStringBuilder.Append("1");
                    carry = 1;
                }
                else
                {
                    // write result, carry 0
                    carry = 0;
                    resultStringBuilder.Append(tempRes);
                }

                bPtr--;
            }

            if (carry != 0)
            {
                resultStringBuilder.Append(carry);
            }

            return new string(resultStringBuilder.ToString().Reverse().ToArray());
        }
    }
}
