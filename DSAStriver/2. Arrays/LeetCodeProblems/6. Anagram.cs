using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAStriver._2._Arrays.LeetCodeProblems
{
    public class Anagram
    {
        //💬 Problem Statement

        //Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        //An anagram is a word or phrase formed by rearranging the letters of a different word.

        //🧠 Example

        //Input:
        //s = "anagram", t = "nagaram"
        //Output: true

        //Input:
        //s = "rat", t = "car"
        //Output: false

        #region 1. Using Dictionary 
        public bool IsAnagramUsingDictionary(string s, string t)
        {
            //  Time: O(n)
            //  Space: O(1)(since only lowercase English letters → fixed size)

            //  🧠 The key idea: “Number of unique keys is bounded”
            //  ✅ For this problem:

            //  Each key in the dictionary is a character.
            //  The input string s consists of lowercase English letters only.
            //  That means there can be at most 26 unique characters.
            //  So, even if s has 1 million characters,
            //  your dictionary can never hold more than 26 entries.
            //  Space complexity = O(26) = O(1)
            if (string.IsNullOrEmpty(s)) return false;
            if (string.IsNullOrEmpty(t)) return false;

            if (s.Length != t.Length) return false;

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char ch in s)
            {
                if (!freq.ContainsKey(ch))
                    freq[ch] = 1;
                else
                    freq[ch]++;
            }

            foreach (char ch in t) {
                if (!freq.ContainsKey(ch)) return false;

                freq[ch]--;
                if (freq[ch] < 0) return false;
            }
            return true;
        }
        #endregion

        #region 2. Using Sorting
        // Time Complexity: O(n log n)
        // Spaec Complexity: O(1)

        public bool IsAngramBySorting(string s, string t)
        {
            if(string.IsNullOrEmpty(s)) return false;
            if(string.IsNullOrEmpty(t)) return false;

            if (s.Length != t.Length) return false;

            return string.Concat(s.OrderBy(x => x)) == string.Concat(t.OrderBy(x => x));
        }
        #endregion
    }
}
