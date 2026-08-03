using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;

namespace DSAStriver._2._Arrays.Claude_AI
{
    public class P008_PrefixSum_HashMap
    {
        #region Leetcode #560 Given an array of integers and an integer k, return the total number of subarrays whose sum equals k.
        //Leetcode #560 — Subarray Sum Equals K
        //Platform:   Leetcode #560
        //Difficulty: Medium
        //Companies:  Amazon, Facebook, Google, Microsoft, Goldman Sachs
        //Pattern:    Prefix Sum + HashMap
        //Problem:

        //Constraints:

        //1 <= nums.length <= 20,000
        //-1000 <= nums[i] <= 1000 — values can be negative
        //-10^7 <= k <= 10^7

        // Why Brute Force won't work
        // n => 20,000 => O(n^2) = 400 million operations = too slow
        // values can be -ve => sliding window won't work 
        // Only operation => O(n) solution using Prefix Sum + HashMap

        //Example:
        //Input:  [1, 2, 3], k = 3
        //Output: 2
        //Reason: [1, 2] and[3] both sum to 3

        // Key Insight
        // If Prefix sum at index j = 10
        // And Prefix sum at index i = 7
        // Then sum of subarray from i + 1 to j => 10 - 7 = 3
        // So if k = 3, this subarray is valid

        // prefix[j] - prefix[i] = k
        // prefix[i] = prefix[j] - k => CurrentSum - k

        public static int SubArraySum(int[] nums, int k)
        {
            var map = new Dictionary<int, int>(); // Prefix Sum + Frequency
            map[0] = 1; // Prefix array should start from 0 (value not index) for better calculations
            int count = 0, currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];  // 1, 3, 6

                int complement = currentSum - k;    // -2, 0, 3

                if (map.ContainsKey(complement))    // -, 0
                    count += map[complement];       // -, 1

                if (map.ContainsKey(currentSum))    // -, 
                    map[currentSum]++;
                else 
                    map[currentSum] = 1;            // (1, 1), 
            }
            return count;
        }

        // Complexity:
        // Time: O(n) | Space: O(n)

        // Dry Run
        //map = {0:1}, count = 0, currentSum = 0

        //i=0: currentSum = 0+1 = 1
        //     complement = 1-3 = -2
        //     -2 not in map
        //     store 1 → map = {0:1, 1:1}

        //i=1: currentSum = 1+2 = 3
        //     complement = 3-3 = 0
        //     0 in map with freq 1 → count = 1
        //     store 3 → map = {0:1, 1:1, 3:1}

        //i=2: currentSum = 3+3 = 6
        //     complement = 6-3 = 3
        //     3 in map with freq 1 → count = 2
        //     store 6 → map = {0:1, 1:1, 3:1, 6:1}

        //Output: 2 ✓
        #endregion

        #region Leetcode #525: Given a binary array, find the maximum length subarray with equal number of 0s and 1s.

        //Platform:   Leetcode #525
        //Difficulty: Medium
        //Companies:  Amazon, Facebook, Google
        //Pattern:    Prefix Sum + HashMap

        //Input:  [0, 1, 0, 1, 1, 0]
        //Output: 4 ==>  → [0,1,0,1] or [1,0,1,1]... find the correct one

        //Hint:
        //Replace every 0 with -1. Now find longest subarray with sum = 0. Use HashMap storing first occurrence of each prefix sum.

        #region Explanation
        //If same prefix sum appears at index i and index j
        //→ subarray between i+1 and j has sum = 0
        //→ length = j - i

        //        Original: [0, 1, 0, 1, 1, 0]
        //        Modified: [-1, 1, -1,  1,  1, -1]

        //        Array:  [-1, 1, -1, 1,  1, -1]
        //        Index:    0  1   2  3   4   5

        //prefix[0] = 0
        //prefix[1] = -1
        //prefix[2] = 0   ← same as prefix[0]
        //prefix[3] = -1  ← same as prefix[1]
        //prefix[4] = 0   ← same as prefix[0]
        //prefix[5] = 1
        //prefix[6] = 0   ← same as prefix[0]

        //            When the same prefix sum appears twice:
        //prefix[i] == prefix[j]
        //→ subarray from i to j-1 has sum 0
        //→ length = j - i

        //            Example:
        //prefix[0] = 0, prefix[2] = 0
        //→ subarray from index 0 to 1 = [-1, 1] → sum 0, length = 2-0 = 2

        //prefix[0] = 0, prefix[4] = 0  
        //→ subarray from index 0 to 3 = [-1,1,-1,1] → sum 0, length = 4-0 = 4

        //prefix[0] = 0, prefix[6] = 0
        //→ length = 6-0 = 6... wait let me verify
        //[-1, 1, -1, 1, 1, -1] = 0 ✓ length 6

        //            Step 4 — HashMap stores FIRST occurrence:
        //We want MAXIMUM length
        //→ earliest first occurrence gives longest subarray
        //→ store index only if prefix sum NOT already in map

        //            Dry run:
        //Array:   [0, 1, 0, 1, 1, 0]
        //Modified:[-1,  1, -1,  1,  1, -1]
        //          0   1   2   3   4   5

        //map = {0:-1}, maxLength = 0, currentSum = 0

        //i=0: nums[0]=0 → currentSum = 0+(-1) = -1
        //     -1 not in map → store map[-1] = 0
        //     map = {0:-1, -1:0}

        //i=1: nums[1]=1 → currentSum = -1+1 = 0
        //     0 in map at index -1
        //     length = 1-(-1) = 2, maxLength = 2
        //     already in map, don't update

        //i=2: nums[2]=0 → currentSum = 0+(-1) = -1
        //     -1 in map at index 0
        //     length = 2-0 = 2, maxLength = 2
        //     already in map, don't update

        //i=3: nums[3]=1 → currentSum = -1+1 = 0
        //     0 in map at index -1
        //     length = 3-(-1) = 4, maxLength = 4
        //     already in map, don't update

        //i=4: nums[4]=1 → currentSum = 0+1 = 1
        //     1 not in map → store map[1] = 4
        //     map = {0:-1, -1:0, 1:4}

        //i=5: nums[5]=0 → currentSum = 1+(-1) = 0
        //     0 in map at index -1
        //     length = 5-(-1) = 6, maxLength = 6
        //     already in map, don't update

        //Output: 6 ✓

        //            Why map[0] = -1:
        //If prefix sum returns to 0 at index j — the entire subarray from 0 to j has equal 0s and 1s.Length = j - (-1) = j + 1. Without -1 you'd miss these cases.

        #endregion

        //Complexity:

        //Time: O(n)
        //Space: O(n)

        public static int BinarySubArraySum(int[] nums)
        {
            var map = new Dictionary<int, int>();
            map[0] = -1;
            int maxLength = 0, currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i] == 0 ? -1 : 1;

                if (map.ContainsKey(currentSum))
                    maxLength = Math.Max(maxLength, i - map[currentSum]);
                else
                    map[currentSum] = i;
            }
            return maxLength;
        }
        #endregion
    }
}
