using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAStriver._2._Arrays.LeetCodeProblems
{
    public class TwoSum
    {
        #region 1. Two Sum Array 

        //Hint
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //You can return the answer in any order.

        //Example 1:

        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0, 1]
        //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        //Example 2:

        //Input: nums = [3, 2, 4], target = 6
        //Output: [1, 2]
        //Example 3:

        //Input: nums = [3, 3], target = 6
        //Output: [0, 1]


        //Constraints:

        //2 <= nums.length <= 104
        //-109 <= nums[i] <= 109
        //-109 <= target <= 109
        //Only one valid answer exists.


        //Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
        #endregion

        // Demo Array int[] arr = { 10, 20, 4, 7, 5 };

        #region 1. O(n^2) Time Complexity
        public int[] TwoSumArrayBasic(int[] nums, int target) // Returns 1D array, if return type is int[,] => 2D Array
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[0];
        }
        #endregion

        #region 2. O(n) Time Complexity (Efficient one but uses more memory)
        public int[] TwoSumDictionary(int[] nums, int target)
        {
            if (nums.Length < 2) return new int[0];

            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int requiredNumber = target - nums[i];

                if (map.ContainsKey(requiredNumber))
                    return new int[] { map[requiredNumber], i }; // Required Output

                if (!map.ContainsKey(nums[i]))  // avoid duplicate overrides
                    map[nums[i]] = i;
            }
            return new int[0];
        }
        #endregion
    }
}
