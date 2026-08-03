/*
 * P002 — Two Sum (Unsorted Array)
 * ────────────────────────────────
 * Problem:
 *   Given an UNSORTED array of integers and a target,
 *   return indices of two numbers that add up to target.
 *
 * Constraints:
 *   - Array is NOT sorted
 *   - Values can be negative
 *   - Exactly one solution exists
 *   - Cannot use the same element twice
 *   - 2 <= nums.length <= 100,000
 *
 * Example:
 *   Input:  [3, 7, 1, 5], target = 8
 *   Output: [0, 3]  (3 + 5 = 8)
 *
 * Approach: HashMap (Dictionary)
 *   - For each number, calculate complement = target - current
 *   - Check if complement already exists in Dictionary
 *   - If yes → pair found, return indices
 *   - If no  → store current number and its index in Dictionary
 *
 *   Why not Two Pointers here?
 *   Array is unsorted and values can be negative.
 *   Two pointers requires sorted array to work correctly.
 *
 *   Key insight:
 *   By checking complement BEFORE storing current number,
 *   we naturally prevent using the same index twice.
 *
 * Complexity:
 *   Time:  O(n) — single pass through array
 *   Space: O(n) — Dictionary stores up to n elements in worst case
 *                 (when the matching pair is at the very end)
 */

public class P002_TwoSum_Unsorted
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>(); // value → index

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
                return new int[] { map[complement], i };

            map[nums[i]] = i;
        }

        return new int[] { -1, -1 };
    }

    public static void Main()
    {
        int[] nums = { 3, 7, 1, 5 };
        int target = 8;

        var result = TwoSum(nums, target);
        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        // Output: Indices: [0, 3]
    }
}
