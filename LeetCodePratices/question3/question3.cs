using System;
using System.Collections.Generic;

namespace LeetCodePratices
{
    public class question3
    {

        /*
         * 3. Longest Substring Without Repeating Characters
         *
         * Given a string, find the length of the longest substring without repeating characters.

            Example 1:

            Input: "abcabcbb"
            Output: 3 
            Explanation: The answer is "abc", with the length of 3. 
            Example 2:

            Input: "bbbbb"
            Output: 1
            Explanation: The answer is "b", with the length of 1.
            Example 3:

            Input: "pwwkew"
            Output: 3
            Explanation: The answer is "wke", with the length of 3. 
                         Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

         */

        public question3()
        {
            LengthOfLongestSubstring("abcabcbb");
        }

        public int LengthOfLongestSubstring(string s)
        {
            var result = 0;

            if (!String.IsNullOrEmpty(s))
            { 
                var tempResult = -1;
                var dictStrings = new Dictionary<char, int>();
                for(int i = 0; i < s.Length; i++)
                {
                    if (dictStrings.ContainsKey(s[i]))
                    {
                        tempResult = Math.Max(tempResult, dictStrings[s[i]]);
                        dictStrings[s[i]] = i;
                    }
                    else
                    {
                        dictStrings.Add(s[i], i);
                        // tempResult = dictStrings[s[i]];
                    }
                    result = Math.Max(result, i - tempResult);
                }
            }

            return result;
        }
    }
}
