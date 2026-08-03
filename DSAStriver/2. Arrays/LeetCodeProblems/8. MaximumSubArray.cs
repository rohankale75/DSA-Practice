using System.Text;

namespace DSAStriver._2._Arrays.LeetCodeProblems
{
    public class MaximumSubArray
    {
        #region Problem (Here Kadane's Algorithm is used)
        //53. Maximum Subarray
        //Medium
        //Topics
        //premium lock icon
        //Companies
        //Given an integer array nums, find the subarray with the largest sum, and return its sum.

        //Example 1:

        //Input: nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
        //Output: 6
        //Explanation: The subarray [4, -1, 2, 1] has the largest sum 6.
        //Example 2:

        //Input: nums = [1]
        //Output: 1
        //Explanation: The subarray [1] has the largest sum 1.
        //Example 3:

        //Input: nums = [5, 4, -1, 7, 8]
        //Output: 23
        //Explanation: The subarray [5, 4, -1, 7, 8] has the largest sum 23.

        //Constraints:

        //1 <= nums.length <= 10^5
        //-10^4 <= nums[i] <= 10^4


        //Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
        #endregion

        #region Solution
        //| Type      | Explanation                       |
        //| --------- | --------------------------------- |
        //| **Time**  | O(n) — one pass through the array |
        //| **Space** | O(1) — only a few variables used  |

        public int MaximumSubArrayKadaneAlgo(int[] arr)
        {
            int currentSum = arr[0];
            int maxSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                currentSum = Math.Max(arr[i], currentSum + arr[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }
        #endregion
    }
}
