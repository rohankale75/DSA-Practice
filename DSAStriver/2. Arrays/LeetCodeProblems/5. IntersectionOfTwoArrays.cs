using Microsoft.VisualBasic;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAStriver._2._Arrays.LeetCodeProblems
{
    public class IntersectionOfTwoArrays
    {
        #region Problem (LC 349, E)
        //  349. Intersection of Two Arrays

        //  Given two integer arrays nums1 and nums2, return an array of their intersection.Each element in the result must be unique and you may return the result in any order.

        //Example 1:

        //Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
        //Output: [2]

        //Example 2:

        //Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
        //Output: [9, 4]
        //Explanation: [4, 9] is also accepted.
        #endregion

        #region Solution
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            List<int> result = new List<int>();

            // Step 1: Store frequency of elements in nums1
            foreach (int num in nums1)
            {
                if (!freq.ContainsKey(num))
                    freq[num] = 1;
                else
                    freq[num]++;
            }

            // Step 2: Check elements from nums2
            foreach (int num in nums2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    if (!result.Contains(num)) // Only Reutrn Non-Duplicate as a result (1st example return [2] but if this condition removed it will return [2, 2]
                        result.Add(num);
                    freq[num]--; // Decrease count
                }
            }

            return result.ToArray();
        }
        #endregion
    }
}
