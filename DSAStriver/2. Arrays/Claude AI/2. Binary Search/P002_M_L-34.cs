using System.ComponentModel;
using System.Security.Cryptography;

namespace DSAStriver._2._Arrays.Claude_AI._2._Binary_Search
{
    public class P002_M_L_34
    {
        #region Q. Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

        #region Problem Statement
        //If target is not found in the array, return [-1, -1].

        //You must write an algorithm with O(log n) runtime complexity.


        //Example 1:

        //Input: nums = [5, 7, 7, 8, 8, 10], target = 8
        //Output: [3, 4]
        //Example 2:

        //Input: nums = [5, 7, 7, 8, 8, 10], target = 6
        //Output: [-1,-1]
        //Example 3:

        //Input: nums = [], target = 0
        //Output: [-1,-1]


        //Constraints:

        //0 <= nums.length <= 10^5
        //-10^9 <= nums[i] <= 10^9
        //nums is a non-decreasing array.
        //-10^9 <= target <= 10^9

        // Complexity
        // Time: O(log n) - two binary searches
        // Space: O(1)

        // Key Insights to remember
        // Find first → when found, save result, go LEFT  (right = mid - 1)
        // Find last  → when found, save result, go RIGHT(left = mid + 1)
        #endregion

        #region Dry Run
        //    Array: [5, 7, 7, 8, 8, 8, 10]
        //    0  1  2  3  4  5   6
        //    Target: 8

        //    Find First
        //    left=0, right=6
        //    mid=3 → nums[3]=8 == target → result=3, right=2

        //    left=0, right=2
        //    mid=1 → nums[1]=7 < 8 → left=2

        //    left=2, right=2
        //    mid=2 → nums[2]=7 < 8 → left=3

        //    left=3 > right=2 → stop
        //    return 3 ✓

        //    Find Last
        //left=0, right=6
        //    mid=3 → nums[3]=8 == target → result=3, left=4

        //    left=4, right=6
        //    mid=5 → nums[5]=8 == target → result=5, left=6

        //    left=6, right=6
        //    mid=6 → nums[6]=10 > 8 → right=5

        //    left=6 > right=5 → stop
        //    return 5 ✓

        // Output: [3, 5]
        #endregion

        public static int[] SearchRange(int[] nums, int target)
        {
            return new int[] { FindLeftMost(nums, target), FindRightMost(nums, target) };
        }

        public static int FindLeftMost(int[] nums, int target)
        {
            int left = 0, mid = 0, right = nums.Length - 1, result = -1;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    right = mid - 1;    // keep searching LEFT for earlier occurrence
                }
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return result;
        }

        public static int FindRightMost(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1, mid = 0, result = -1;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    left = mid + 1;     // keep searching RIGHT for later occurrence
                }
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return result;
        }
        #endregion
    }
}
