using System.Reflection.Metadata;
using System.Xml.Linq;

namespace DSAStriver._2._Arrays.Claude_AI
{
    public class P007_PrefixSum
    {
        #region Prefix Sum (Range Sum Query - Immutable)
        //Platform:    Leetcode #303
        //Difficulty:  Easy
        //Companies:   Amazon, Google, Facebook, Microsoft
        //Pattern:     Prefix Sum

        #region Question
        //Given an integer array nums, handle multiple queries of the following type:

        //Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
        //Implement the NumArray class:

        //NumArray(int[] nums) Initializes the object with the integer array nums.
        //int sumRange(int left, int right) Returns the sum of the elements of nums between indices left and right inclusive(i.e.nums[left] + nums        [left + 1] + ... + nums[right]).


        //Example 1:

        //Input
        //["NumArray", "sumRange", "sumRange", "sumRange"]
        //[[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]
        //Output
        //[null, 1, -1, -3]

        //Explanation
        //NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
        //numArray.sumRange(0, 2); // return (-2) + 0 + 3 = 1
        //numArray.sumRange(2, 5); // return 3 + (-5) + 2 + (-1) = -1
        //numArray.sumRange(0, 5); // return (-2) + 0 + 3 + (-5) + 2 + (-1) = -3


        //Constraints:

        //1 <= nums.length <= 10^4
        //-10^5 <= nums[i] <= 10^5
        //0 <= left <= right<nums.length
        //At most 10^4 calls will be made to sumRange.

        // Example
        //Array:   [2, 1, 5, 2, 3]
        //Queries: (0,2), (1,3), (2,4)
        //Output:  [8, 8, 10]

        // Why PrefixSum
        //Prefix sum approach:
        //Build the prefix array ONCE in the constructor.Then every SumRange call is just one subtraction — O(1).
        //If someone calls SumRange 10,000 times on a 10,000 element array — that's 100 million operations. Too slow.

        // Formula
        // SumRange(left, right) = prefix[right+1] - prefix[left]

        // Complexity:
        // Building prefix = O(n)
        // Each SumRange call = O(1)    (once array is build, need to just call it thats why O(1)
        // Space = O(n)
        #endregion

        public int[] prefix;
        public P007_PrefixSum(int[] nums)
        {
            prefix = new int[nums.Length + 1];
            for (int i = 1; i <= nums.Length; i++)
            {
                prefix[i] = nums[i - 1] + prefix[i -1];
            }
        }

        public int SumRange(int left, int right)
        {
            return prefix[right + 1] - prefix[left];
        }

        #endregion
    }
}
