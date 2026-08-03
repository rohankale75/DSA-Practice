using System;
using System.Drawing;
using System.Security.Cryptography;

namespace DSAStriver._2._Arrays.Claude_AI
{
    public class P005_SlidingWindow_Fixed
    {
        #region Fixed Sliding windos
        #region Q. Find the maximum sum of subarray whose window size is k = 3

        // { 0, 1, 2, 3, 4, 5 } => Index of array
        // { 2, 1, 5, 1, 3, 2 } => values of array
        // windowSum = 8 => (2 + 1 + 5 = 8)

        // 8 + 1 - 2 => 7
        // 7 + 3 - 1 => 9 => o/p: max sum = 9
        // 9 + 2 - 5 => 6


        // Constraints:

        //1 <= nums.length <= 100,000
        //1 <= k <= nums.length

        #region Logic
        // Step 1: Calculate sum of first window[2, 1, 5] = 8
        // Step 2: Slide right
        //  Add nums[3] = 1 → sum = 9
        //  Remove nums[0] = 2 → sum = 7... wait

        //Actually:
        //  new sum = old sum + nums[right] - nums[left]
        //  = 8 + 1 - 2 = 7

        // Step 3: Slide right again
        //  new sum = 7 + 3 - 1 = 9

        // Step 4: Slide right again
        //  new sum = 9 + 2 - 5 = 6

        // Maximum seen = 9 ✓
        #endregion

        public static int MaxSubArray(int[] nums, int k)
        {
            if (nums.Length < k) return 0;
            int windowSum = 0;
            // Calculate first window sum
            for (int i = 0; i < k; i++)
            {
                windowSum += nums[i];
            }

            int maxSum = windowSum;

            // Slide the window
            for (int i = k; i < nums.Length; i++)
            {
                windowSum += nums[i] - nums[i - k];  // add new, remove old
                maxSum = Math.Max(maxSum, windowSum);
            }

            return maxSum;
        }
        //Complexity:

        //Time: O(n) — single pass
        //Space: O(1) — just two integer variables
        #endregion

        #region Q. Find the minimum sum of subarray whose window size is k = 3

        //Input:  [2, 1, 5, 1, 3, 2], k = 3
        //Output: 4
        //Reason: subarray[1, 3, 2]... wait, actually[2, 1, 1]?

        public static int MinSubArray(int[] nums, int k)
        {
            if (nums.Length < k) return 0;

            int windowSum = 0;

            for (int i = 0; i < k; i++)
            {
                windowSum += nums[i];
            }
            int minSum = windowSum;

            for (int i = k; i < nums.Length; i++)
            {
                windowSum += nums[i] - nums[i - k];
                minSum = Math.Min(minSum, windowSum);
            }
            return minSum;
        }
        #endregion

        #endregion
    }
}
