using System;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace DSAStriver._2._Arrays.LeetCodeProblems
{
    public class MajorityElement
    {

        // E.g. Arrays
        // nums = [2, 2, 1, 1, 1, 2, 2], output = 2
        // nums = [3,2,3] , output: 3

        #region 1. Using Dictionary
        // Complexity:
        // 1. Time Complexity: O(n)
        //      We Loop once through all elements of Array nums
        //      Dictionary operations like ContainsKey() and [] (accessing element) takes constant time of O(1) on average (hash table lookup)
        //      So Total = n * O(1) = O(n)

        // 2. Space Complexity: O(n)
        // In the worst case scenario, all numbers might be unique, so might need to traverse the whole array to story 'n' key value pairs
        // So Space Complexity: O(n)
        public int MajorityElementDictionary(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int n = nums.Length;

            foreach (int num in nums)
            {
                if (!map.ContainsKey(num))
                    map[num] = 1;
                else
                    map[num]++;

                if (map[num] > n / 2)
                    return num;
            }
            return 0;
        }

        // 💡 When to use Dictionary

        //✅ When you need frequency counts or multiple candidates, not just a single majority.
        // Examples:
        //  1. Count character frequency in a string.
        //  2. Find most frequent element in an array.
        //  3. Problems like “Top K Frequent Elements”, “Group Anagrams”, etc.
        #endregion

        #region 2. Boyer-Moore Voting Algorithm - "Cancelling Oppopnents (Like Elections)"
        // Complexity: 
        // 1. Time Complexity: O(n)
        // Need to go through the whole array, no nested loops or lookups

        // 2. Space Complexity: O(1)
        // We only store two variables, candidate and count
        public int MajorityElementBoyerMooreAlgo(int[] nums)
        {
            int count = 0, candidate = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                    candidate = num;

                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }

        //💡 When to use Boyer–Moore
        //  ✅ When:
        //      - There’s guaranteed to be exactly one majority(like > n/2 times).
        //      - You don’t need counts, just the final “winner”.

        //  Not good when:
        //      - There’s no guaranteed majority — it could return a wrong result unless verified afterward.
        #endregion
    }
}
