using System.Security.Cryptography;

namespace DSAStriver._2._Arrays.Claude_AI._1._Array_Must_Do_Patterns
{
    public class P008_DutchNationalFlag
    {
        #region Dutch National Flag Algorithm — Sort 0s, 1s, 2s Q. Given an array with only 0s, 1s, and 2s, sort it in place without using a sorting function.

        //Platform:   Leetcode #75
        //Difficulty: Medium
        //Companies:  Amazon, Microsoft, Facebook, Adobe
        //Pattern:    Dutch National Flag(3-way partitioning)
        //Problem:

        //Constraints:

        //1 <= nums.length <= 300
        //nums[i] is 0, 1, or 2 only

        //Example:
        //Input:  [2, 0, 2, 1, 1, 0]
        //Output: [0, 0, 1, 1, 2, 2]

        //Why not just use a sort function:
        //Interviewers want O(n) single pass, not O(n log n) sorting.Also — the challenge is doing it in-place without extra array.

        #region Brute Force 
        // Count each then rebuild array - O(n) but two passes, uses extra space conceptually

        //int count0 = 0, count1 = 0, count2 = 0;
        //foreach (var num in nums) {
        //    if (num == 0) count0++;
        //    else if (num == 1) count1++;
        //    else count2++;
        //}

        // then overwrite array based on counts
        #endregion

        // Brute force works but interviewers want the elegant one pass solution - "Three Pointers"

        // The Key Insight - Three Pointers

        // low    → boundary for 0s, everything before low is 0
        // mid    → current element being checked
        // high   → boundary for 2s, everything after high is 2

        // Array divided into 4 zones:
        // [0...low - 1] = all 0s
        // [low...mid - 1] = all 1s
        // [mid...high] = unprocessed
        // [high + 1...end] = all 2s

        // Logic

        // If nums[mid] == 0:
        // → swap nums[low] and nums[mid]
        // → low++, mid++ (both move forward)

        // If nums[mid] == 1:
        // → mid++ (just move forward, 1 is already in right place)

        // If nums[mid] == 2:
        // → swap nums[mid] and nums[high]
        // → high-- (only high moves back, mid stays — need to recheck swapped value)

        public static void SortColors(int[] nums)
        {
            int low = 0, mid = 0, high = nums.Length - 1;

            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    (nums[low], nums[mid]) = (nums[mid], nums[low]);    // Swapping technique
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)
                    mid++;
                else
                {
                    (nums[mid], nums[high]) = (nums[high], nums[mid]);  // Swapping technique
                    high--;
                }
            }
        }

        // Complexity
        // TC: O(n) | SC: O(1)

        #region Dry run:

        // Array: [2, 0, 2, 1, 1, 0]
        // Index:  0  1  2  3  4  5
        // low=0, mid=0, high=5

        // mid=0: nums[0]=2 → swap nums[0], nums[5] → [0, 0, 2, 1, 1, 2]
        // high-- → high=4
        // (mid stays at 0, recheck)

        // mid=0: nums[0]=0 → swap nums[0], nums[0] → no change[0, 0, 2, 1, 1, 2]
        // low++, mid++ → low=1, mid=1

        // mid=1: nums[1]=0 → swap nums[1], nums[1] → no change
        // low++, mid++ → low=2, mid=2

        // mid=2: nums[2]=2 → swap nums[2], nums[4] → [0, 0, 1, 1, 2, 2]
        // high-- → high=3
        // (mid stays at 2, recheck)

        // mid=2: nums[2]=1 → mid++ → mid=3

        // mid=3: nums[3]=1 → mid++ → mid=4

        // mid=4 > high=3 → stop

        // Result: [0, 0, 1, 1, 2, 2] ✓
        #endregion

        // Why mid doesn't increment when swapping with high:
        // The value swapped INTO position mid from high hasn't been checked yet. It could be 0, 1, or 2. So you must recheck it — don't advance mid.
        // But when swapping with low — the value coming from low into mid is guaranteed to be either 0 or 1 (already processed region), safe to move forward.
        #endregion
    }
}
