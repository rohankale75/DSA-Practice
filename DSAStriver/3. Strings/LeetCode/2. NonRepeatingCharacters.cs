using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAStriver._3._Strings.LeetCode
{
    internal class NonRepeatingCharacters
    {
        #region Problem
        // 387. First Unique Character in a String
        //Easy
        //Topics
        //premium lock icon
        //Companies
        //Given a string s, find the first non-repeating character in it and return its index.If it does not exist, return -1.

        //Example 1:

        //Input: s = "leetcode"

        //Output: 0

        //Explanation:

        //The character 'l' at index 0 is the first character that does not occur at any other index.

        //Example 2:

        //Input: s = "loveleetcode"

        //Output: 2

        //Example 3:

        //Input: s = "aabb"

        //Output: -1

        //Constraints:

        //1 <= s.length <= 105
        //s consists of only lowercase English letters.
        #endregion

        #region Solution
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!map.ContainsKey(c)) map[c] = 1;
                else map[c]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (map[s[i]] == 1) return i;   // Return index of Key
            }
            return -1;
        }
        #endregion
    }
}
