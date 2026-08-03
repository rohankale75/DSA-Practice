/*
 * P001 — Two Sum (Sorted Array)
 * ─────────────────────────────
 * Problem:
 *   Given a SORTED array of integers and a target,
 *   return indices of two numbers that add up to target.
 *
 * Constraints:
 *   - Array is sorted in ascending order
 *   - Exactly one solution exists
 *   - Cannot use the same element twice
 *   - 2 <= nums.length <= 10,000
 *
 * Example:
 *   Input:  [1, 3, 5, 7, 9], target = 10
 *   Output: [1, 3]  (3 + 7 = 10)
 *
 * Approach: Two Pointers
 *   - Place left pointer at start, right pointer at end
 *   - If sum == target → found
 *   - If sum < target  → move left pointer right (need bigger number)
 *   - If sum > target  → move right pointer left (need smaller number)
 *   - Loop ends when pointers meet
 *
 *   Why not HashMap here?
 *   Array is sorted → two pointers gives O(1) space vs O(n) for HashMap
 *   Always prefer two pointers on sorted arrays.
 *
 * Complexity:
 *   Time:  O(n) — single pass, pointers move towards each other
 *   Space: O(1) — no extra data structure, just two integer variables
 */

public class P001_TwoSum_Sorted
{
    public static int[] TwoSum(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int sum = arr[left] + arr[right];

            if (sum == target)
                return new int[] { left, right };
            else if (sum < target)
                left++;
            else
                right--;
        }

        return new int[] { -1, -1 };
    }

    public static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9 };
        int target = 10;

        var result = TwoSum(arr, target);
        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        // Output: Indices: [1, 3]
    }
}
