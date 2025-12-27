using System;

namespace DSAStriver._3._Strings.Basic_Problems
{
    public class PalindromeString
    {
        // 2️ Check Palindrome(Simple)
        // Problem

        // Input: "madam" → true
        // Input: "hello" → false

        // Pattern used: Two Pointers (Compare characters from both ends)

        public static bool PalindromeStringMethod(string str)
        {
            int left = 0, right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }
            return true;
        }
    }
}
