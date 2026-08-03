using System.Collections.Generic;

namespace DSAStriver._2._Arrays.Claude_AI
{
    public class P006_SlidingWindow_Dynamic
    {
        #region Q. 1. Given an array of positive integers and a target sum S, find the length of the smallest subarray whose sum is greater than or equal to S.

        //Input:  [2, 1, 5, 2, 3, 2], S = 7
        //Output: 2
        //Reason: [5, 2] sums to 7, length = 2

        //Constraints:

        //1 <= nums.length <= 100,000
        //1 <= nums[i] <= 10,000
        //1 <= S <= 100,000,000
        //All values positive

        // Expand right → add to windowSum
        // When windowSum >= S:
        //  → update minLength
        //  → shrink from left → subtract from windowSum
        //  → keep shrinking while condition still holds
        //  → this finds the smallest valid window
        public static int MinSubArrayLength(int[] nums, int s)
        {
            int left = 0, windowSum = 0;
            int minLength = int.MaxValue;

            for (int right = 0; right < nums.Length; right++)
            {
                windowSum += nums[right];

                while (windowSum >= s)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    windowSum -= nums[left];
                    left++;
                }
            }
            return minLength == int.MaxValue ? 0 : minLength;
        }

        // Time: O(n) | Space: O(1)

        #endregion

        #region Q. 2. Find the length of the longest substring without repeating characters.
        //Input:  "abcabcbb"
        //Output: 3  → "abc"

        //Input:  "bbbbb"  
        //Output: 1  → "b"
        public static int MaxSubArrayLength(char[] chars)
        {
            HashSet<char> hs = new HashSet<char>();
            int maxLength = 0, left = 0;
            for (int right = 0; right < chars.Length; right++)
            {
                while (hs.Contains(chars[right]))
                {
                    hs.Remove(chars[left]);
                    left++;
                }

                hs.Add(chars[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;
        }

        //Leetcode #3
        //Difficulty: Medium
        //Companies: Amazon, Google, Microsoft, Adobe, Goldman Sachs
        //Pattern: Dynamic Sliding Window + HashSet
        //Time: O(n) | Space: O(n)
        #endregion
    }
}
