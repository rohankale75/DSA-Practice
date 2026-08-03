/*
 * P004 — Count Pairs That Sum to Target (Large Input)
 * ─────────────────────────────────────────────────────
 * Problem:
 *   Given an array of integers and a target k,
 *   return the COUNT of pairs (i, j) where i < j
 *   and nums[i] + nums[j] == k.
 *
 * Constraints:
 *   - 1 <= nums.length <= 100,000     ← large input, O(n²) NOT acceptable
 *   - -1000 <= nums[i] <= 1000        ← values can be negative
 *   - Array is unsorted
 *   - Duplicate values possible (e.g. [3, 3, 3])
 *
 * Example:
 *   Input:  [1, 5, 3, 3, 2], k = 6
 *   Output: 2   (pairs: [1,5] and [3,3])
 *
 *   Duplicate example:
 *   Input:  [3, 3, 3], k = 6
 *   Output: 3   (pairs: (0,1), (0,2), (1,2))
 *
 * Approach: HashMap with Frequency Count
 *   Why not brute force?
 *   n = 100,000 → n² = 10 billion operations. Too slow.
 *
 *   Why frequency count instead of just storing index?
 *   If array has duplicates like [3, 3, 3], storing just one index
 *   would miss multiple valid pairs. Frequency tracks how many
 *   times we've seen a number so far.
 *
 *   Logic:
 *   - For each number, complement = k - current
 *   - If complement exists in map → add its frequency to count
 *     (all previously seen complements form valid pairs with current)
 *   - Then increment frequency of current number in map
 *
 *   Key insight:
 *   By checking complement BEFORE storing current number,
 *   i < j is naturally guaranteed (complement was seen earlier).
 *
 * Complexity:
 *   Time:  O(n) — single pass through array
 *   Space: O(n) — Dictionary stores up to n distinct values
 *                 worst case: all elements are unique
 */

public class P004_CountPairs_LargeInput
{
    public static int CountPairs(int[] nums, int k)
    {
        if (nums.Length < 2) return 0;

        var map = new Dictionary<int, int>(); // value → frequency
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = k - nums[i];

            if (map.ContainsKey(complement))
                count += map[complement]; // add ALL previous occurrences of complement

            if (map.ContainsKey(nums[i]))
                map[nums[i]]++;
            else
                map[nums[i]] = 1;
        }

        return count;
    }

    public static void Main()
    {
        // Test 1 — basic
        int[] nums1 = { 1, 5, 3, 3, 2 };
        Console.WriteLine(CountPairs(nums1, 6)); // Output: 2

        // Test 2 — duplicates
        int[] nums2 = { 3, 3, 3 };
        Console.WriteLine(CountPairs(nums2, 6)); // Output: 3

        // Test 3 — negative values
        int[] nums3 = { -1, 1, 0, 2, -2 };
        Console.WriteLine(CountPairs(nums3, 0)); // Output: 2 ([-1,1] and [-2,2])
    }
}
