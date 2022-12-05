using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgoPrep.Week4
{
    public class EncodeWordsSln
    {

        // Encodes a list of strings to a single string.
        public string encode(IList<string> strs)
        {
            StringBuilder strBuilder = new StringBuilder();
            StringBuilder wordsBuilder = new StringBuilder();

            int numberOfWords = strs.Count;

            strBuilder.Append(string.Format("[{0},", numberOfWords));

            for (int i = 0; i < strs.Count; ++i)
            {
                strBuilder.Append(strs[i].Length);
                if (i + 1 != strs.Count)
                {
                    strBuilder.Append(',');
                }

                wordsBuilder.Append(strs[i]);
            }

            strBuilder.Append(']');


            strBuilder.Append(wordsBuilder);

            return strBuilder.ToString();
        }

        // Decodes a single string to a list of strings.
        public IList<string> decode(string s)
        {
            int lastIndex = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == ']')
                {
                    lastIndex = i;
                    break;
                }
            }

            string mapStr = s.Substring(1, lastIndex - 1);
            string[] encodingMap = mapStr.Split(",");
            string words = s.Substring(lastIndex + 1);
            IList<string> strs = new List<string>();
            StringBuilder strBuilder;
            int globalPointer = 0;

            for (int i = 0; i < int.Parse(encodingMap[0]); ++i)
            {
                strBuilder = new StringBuilder();
                int end = int.Parse(encodingMap[i + 1]) + globalPointer;
                for (int j = globalPointer; j < end; ++j)
                {
                    strBuilder.Append(words[j]);
                    globalPointer++;
                }

                strs.Add(strBuilder.ToString());
            }

            return strs;
        }
    }
}

