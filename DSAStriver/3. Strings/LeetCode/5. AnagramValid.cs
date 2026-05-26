namespace DSAStriver._3._Strings.LeetCode
{
    public class AnagramValid
    {
        // 242. Valid Anagram
        //Easy

        //Given two strings s and t, return true if t is an anagram of s, and false otherwise.


        //Example 1:

        //Input: s = "anagram", t = "nagaram"

        //Output: true

        //Example 2:

        //Input: s = "rat", t = "car"

        //Output: false

        //Constraints:

        //1 <= s.length, t.length <= 5 * 104
        //s and t consist of lowercase English letters.

        public bool IsValidAnagram(string s, string t)
        {
            if (s == null || t == null) return false;
            if (s.Length !=  t.Length) return false;


            int[] freq = new int[26];   // only lowercase letters hence only 26 characters of alphabet

            foreach (char c in s)
            {
                freq[c - 'a']++;
            }

            foreach (char c in t)
            {
                freq[c - 'a']--;

                if (freq[c - 'a'] < 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Complexity: 
        // Time : O(n)
        // Space : O(1) (26 size array)

    }
}
