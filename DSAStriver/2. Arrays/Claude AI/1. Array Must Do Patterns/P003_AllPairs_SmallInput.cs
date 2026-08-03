/*
 * P003 — All Pairs That Sum to Target (Small Input)
 * ──────────────────────────────────────────────────
 * Problem:
 *   Given an array of integers, return ALL pairs (i, j)
 *   where i < j and nums[i] + nums[j] == target.
 *
 * Constraints:
 *   - 1  <= nums.length <= 100        ← small input, O(n²) acceptable
 *   - -1000 <= nums[i] <= 1000        ← values can be negative
 *   - Array is unsorted
 *   - Multiple pairs possible
 *
 * Example:
 *   Input:  [3, 1, 4, 2, 5, 7], target = 8
 *   Output: [[1, 7], [3, 5]]
 *
 * Approach: Brute Force — Nested Loops
 *   Why brute force here?
 *   n <= 100 means max 10,000 iterations. That's trivial for any machine.
 *   O(n²) is perfectly acceptable. No need to over-engineer.
 *
 *   Key trick:
 *   Start inner loop at j = i + 1 (not j = 0 or j = 1).
 *   This naturally guarantees i < j without any extra check.
 *
 * Complexity:
 *   Time:  O(n²) — nested loops, acceptable given n <= 100
 *   Space: O(k)  — where k is number of matching pairs found
 *                  output list only, no extra working memory
 */

public class P003_AllPairs_SmallInput
{
    public static List<int[]> FindAllPairs(int[] nums, int target)
    {
        if (nums.Length < 2) return new List<int[]>();

        var result = new List<int[]>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++) // j starts at i+1, guarantees i < j
            {
                if (nums[i] + nums[j] == target)
                    result.Add(new int[] { nums[i], nums[j] });
            }
        }

        return result;
    }

    public static void Main()
    {
        int[] nums = { 3, 1, 4, 2, 5, 7 };
        int target = 8;

        var pairs = FindAllPairs(nums, target);
        foreach (var pair in pairs)
            Console.WriteLine($"[{pair[0]}, {pair[1]}]");
        // Output:
        // [1, 7]
        // [3, 5]
    }
}
