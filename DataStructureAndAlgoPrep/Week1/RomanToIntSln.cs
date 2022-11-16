using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week1
{
    public class RomanToIntSln
    {
        private IDictionary<string, int> twoCharValues = new Dictionary<string, int>
        {
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400 },
            { "CM", 900 },
        };

        private IDictionary<string, int> charValues = new Dictionary<string, int>
        {
            { "I", 1    },
            { "V", 5    },
            { "X", 10   },
            { "L", 50   },
            { "C", 100  },
            { "D", 500  },
            { "M", 1000 },
        };

        public int RomanToInt(string s)
        {
            int value = 0;
            int index = 0;

            while (index < s.Length)
            {
                if (IsNextValueTwoChars(s, index))
                {
                    value += twoCharValues[s.Substring(index, 2)];
                    index += 2;
                    continue;
                }

                var nextIndex = GetNextIndexOfDifferentValue(s, index);
                var tempValue = charValues[s.Substring(index, 1)];
                value += ((nextIndex - index) * tempValue);

                index = nextIndex;
            }

            return value;
        }

        public int GetNextIndexOfDifferentValue(string s, int curIndex)
        {
            var curValue = s[curIndex];

            curIndex++;

            while (curIndex < s.Length && s[curIndex] == curValue)
            {
                curIndex++;
            }

            return curIndex;
        }

        public bool IsNextValueTwoChars(string s, int curIndex)
        {
            if (curIndex >= s.Length - 1)
            {
                return false;
            }

            return twoCharValues.ContainsKey(s.Substring(curIndex, 2));
        }
    }
}

