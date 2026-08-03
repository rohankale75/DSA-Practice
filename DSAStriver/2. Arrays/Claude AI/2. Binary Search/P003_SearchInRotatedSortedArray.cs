using System;
using System.Globalization;
using System.Security.Cryptography;

namespace DSAStriver._2._Arrays.Claude_AI._2._Binary_Search
{
    public class P003_SearchInRotatedSortedArray
    {
        #region Q. #33 — Search in Rotated Sorted Array:
        //Platform:   Leetcode #33
        //Difficulty: Medium
        //Companies:  Amazon, Microsoft, Google, Facebook
        //Pattern:    Binary Search with condition

        //Problem:
        //A sorted array was rotated at some pivot.Find target.
        //Original: [1, 2, 3, 4, 5, 6, 7]
        //Rotated:  [4, 5, 6, 7, 1, 2, 3] ← rotated at index 3

        //Input:  [4, 5, 6, 7, 1, 2, 3], target = 1
        //Output: 4

        #region Key Insights
        //       Even after rotation — one half is always sorted.
        //       [4, 5, 6, 7, 1, 2, 3]
        //↑           ↑       ↑
        //       left mid     right

        //       Left half[4, 5, 6, 7] → sorted ✓
        //       Right half [1, 2, 3]   → sorted ✓

        //       At any mid point, either left half OR right half is always sorted.
        //       So the approach:
        //       Find mid
        //       Check which half is sorted
        //       Check if target lies in the sorted half
        //       Yes → search that half
        //       No  → search other half
        #endregion

        #region Dry Run

        //Array:  [4, 5, 6, 7, 1, 2, 3]
        //Index:   0  1  2  3  4  5  6
        //Target: 1
        //left=0, right=6
        //mid=3 → nums[3]=7, not target

        //nums[left]=4 <= nums[mid]=7 → left half[4, 5, 6, 7] is sorted
        //Is 1 in [4, 7]? → 4<=1? No
        //→ search right half → left=4

        //left=4, right=6
        //mid=5 → nums[5]=2, not target

        //nums[left]=1 <= nums[mid]=2 → left half[1, 2] is sorted
        //Is 1 in [1, 2]? → 1<=1 && 1<2? Yes
        //→ search left half → right=4

        //left=4, right=4
        //mid=4 → nums[4]=1 == target → return 4 ✓

        #endregion

        public static int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target) return mid;

                // Left half is sorted
                if (nums[left] <= nums[mid])
                {
                    // Is target in left half?
                    if (nums[left] <= target && target < nums[mid])
                        right = mid - 1; // search left
                    else
                        left = mid + 1;  // search right
                }
                // Right half is sorted
                else
                {
                    // Is target in right half?
                    if (nums[mid] < target && target <= nums[right])
                        left = mid + 1;  // search right
                    else
                        right = mid - 1; // search left
                }
            }
            return -1;
        }
        //Complexity:

        //Time: O(log n)
        //Space: O(1)

        #endregion
    }
}
