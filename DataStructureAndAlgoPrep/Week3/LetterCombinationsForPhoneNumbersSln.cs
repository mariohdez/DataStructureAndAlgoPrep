using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgoPrep.Week3
{
    public class LetterCombinationsForPhoneNumbersSln
    {
        private Dictionary<int, IList<char>> digitToLettersMap = new Dictionary<int, IList<char>>
        {
            { 2, new List<char> { 'a','b','c',      } },
            { 3, new List<char> { 'd','e','f',      } },
            { 4, new List<char> { 'g','h','i',      } },
            { 5, new List<char> { 'j','k','l',      } },
            { 6, new List<char> { 'm','n','o',      } },
            { 7, new List<char> { 'p','q','r', 's', } },
            { 8, new List<char> { 't','u','v',      } },
            { 9, new List<char> { 'w','x','y', 'z', } },
        };

        public IList<string> LetterCombinations(string digits)
        {
            IList<string> results = new List<string>();

            if (string.IsNullOrEmpty(digits))
                return results;

            DFS(digits, 0, new StringBuilder(), results);

            return results;
        }

        public void DFS(string digits, int currentIndex, StringBuilder currentCombination, IList<string> results)
        {
            if (currentIndex >= digits.Length)
            {
                results.Add(currentCombination.ToString());
                return;
            }

            int digit = digits[currentIndex] - '0';

            foreach (char letter in this.digitToLettersMap[digit])
            {
                currentCombination.Append(letter);

                DFS(
                    digits: digits,
                    currentIndex: currentIndex + 1,
                    currentCombination: currentCombination,
                    results: results);

                currentCombination.Remove(currentCombination.Length - 1, 1);
            }
        }
    }
}
