using System;
namespace DataStructureAndAlgoPrep.Week1
{
    public class LongestCommonPrefixSln
    {
        public string LongestCommonPrefix(string[] strs)
        {
            for (int i = 0; i < strs[0].Length; ++i)
            {
                char currentCharacter = strs[0][i];

                for (int j = 1; j < strs.Length; ++j)
                {
                    if (i >= strs[j].Length || strs[j][i] != currentCharacter)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }

            return strs[0];
        }
    }
}

