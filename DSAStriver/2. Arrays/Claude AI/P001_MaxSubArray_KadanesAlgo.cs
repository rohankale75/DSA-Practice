using System.Diagnostics.Metrics;

namespace DSAStriver._2._Arrays.Claude_AI
{
    public class P001_MaxSubArray_KadanesAlgo
    {
        #region Q. Kadane's Algorithm — Maximum Subarray Sum
        // Platform:   Leetcode #53
        // Difficulty: Medium
        // Companies:  Amazon, Microsoft, Google, Apple, LinkedIn
        // Pattern:    Kadane's Algorithm

        //     Problem:

        // Given an integer array, find the contiguous subarray with the largest sum and return that sum.

        // Constraints:

        // 1 <= nums.length <= 100,000
        //- 10,000 <= nums[i] <= 10,000 — values can be negative

        // Example:
        // Input:  [-2, 1, -3, 4, -1, 2, 1, -5, 4]
        // Output: 6
        // Reason: [4, -1, 2, 1] has the largest sum = 6

        // Why brute force won't work:
        // n = 100,000 → O(n²) checking every subarray = 10 billion operations.Too slow.Need O(n).

        // The key insight — Kadane's logic:
        // At every position, you ask one question:

        //" Should I extend the previous subarray, or start fresh from here?"

        // If currentSum + nums[i] is worse than nums[i] alone
        //→  Starting fresh is better
        //→  currentSum = nums[i]

        // Else
        //→  Extending is better
        //→  currentSum = currentSum + nums[i]

        // In other words:
        // currentSum = Math.Max(nums[i], currentSum + nums[i])
        //?  If your running sum becomes negative, it's dragging down everything after it. Better to drop it and start fresh.

        public static int MaxSubArray(int[] nums)
        {
            var currentSum = nums[0];
            var maxSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }

        // Constraints
        // TC: O (n) | SC: O (1)
        #endregion

        #region Dry Run

        // Array: [-2, 1, -3, 4, -1, 2, 1, -5, 4]
                // Index:   0  1   2  3   4  5  6   7  8
        // currentSum = -2, maxSum = -2

        // i=1: currentSum = max(1, -2+1) = max(1,-1) = 1
            // maxSum = max(-2, 1) = 1

        // i=2: currentSum = max(-3, 1+-3) = max(-3,-2) = -2
            // maxSum = max(1, -2) = 1

        // i=3: currentSum = max(4, -2+4) = max(4,2) = 4
            // maxSum = max(1, 4) = 4

        // i=4: currentSum = max(-1, 4+-1) = max(-1,3) = 3
            // maxSum = max(4, 3) = 4

        // i=5: currentSum = max(2, 3+2) = max(2,5) = 5
            // maxSum = max(4, 5) = 5

        // i=6: currentSum = max(1, 5+1) = max(1,6) = 6
            // maxSum = max(5, 6) = 6

        // i=7: currentSum = max(-5, 6+-5) = max(-5,1) = 1
            // maxSum = max(6, 1) = 6

        // i=8: currentSum = max(4, 1+4) = max(4,5) = 5
            // maxSum = max(6, 5) = 6

        // Output: 6 ✓

        #endregion
    }
}
