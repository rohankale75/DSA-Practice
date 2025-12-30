using System.Text.RegularExpressions;

namespace DSAStriver._3._Strings.LeetCode
{
    internal class PalindromeString
    {
        #region Problem
        // 125. Valid Palindrome
        //Solved
        //Easy
        //Topics
        //premium lock icon
        //Companies
        //A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward.Alphanumeric characters include letters and numbers.

        //Given a string s, return true if it is a palindrome, or false otherwise.

        //Example 1:

        //Input: s = "A man, a plan, a canal: Panama"
        //Output: true
        //Explanation: "amanaplanacanalpanama" is a palindrome.
        //Example 2:

        //Input: s = "race a car"
        //Output: false
        //Explanation: "raceacar" is not a palindrome.
        //Example 3:

        //Input: s = " "
        //Output: true
        //Explanation: s is an empty string "" after removing non-alphanumeric characters.
        //Since an empty string reads the same forward and backward, it is a palindrome.

        //Constraints:

        //1 <= s.length <= 2 * 105
        //s consists only of printable ASCII characters.
        #endregion

        #region Solution
        // 1st Solution
        public bool IsPalindromeMethod(string s)
        {
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(s[left])) left++;
                while (left < right && !char.IsLetterOrDigit(s[right])) right--;

                if (char.ToLower(s[left]) != char.ToLower(s[right])) return false;

                left++;
                right--;
            }
            return true;
        }

        // 2nd Solution
        public bool IsPalindrome(string s)
        {
            s = Regex.Replace(s.ToLower(), "[^a-zA-Z0-9]", string.Empty);
            char[] ch = s.ToCharArray();
            int left = 0, right = ch.Length - 1;

            while (left < right)
            {
                if (ch[left] != ch[right]) return false;

                left++;
                right--;
            }
            return true;
        }
        #endregion
    }
}
