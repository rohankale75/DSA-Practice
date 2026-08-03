namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class FindMissingNumber
    {

        // Problem: Find Missing Number from given Array

        // Input: arr[] = [8, 2, 4, 5, 3, 7, 1]
        // Output: 6
        // Explanation: All the numbers from 1 to 8 are present except 6.

        // Input: arr[] = [1, 2, 3, 5]
        // Output: 4
        // Explanation: Here the size of the array is 4, so the range will be[1, 5]. The missing number between 1 to 5 is 4

        public static int FindMissingNumberMethod(int[] nums)
        {
            // { 8, 2, 4, 5, 3, 7, 1 }, n = 7 (length of given array)
            // Above e.g. has 1 element missing which we need to find, hence n = n + 1 => 7 + 1 => FinalLength = 8
            // actualSum = 30
            // length = 8
            // expected = 8 * (8 + 1) / 2 => 36
            // O/p = 36 - 30 = 6 => Expected Output i.e. missing number

            // Claude: Array has n elements, range 0 to n  → expectedSum = n*(n+1)/2
            // Array has n elements, range 1 to n+1 → expectedSum = (n + 1) * (n + 2) / 2

            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;
            
            foreach (var num in nums)
            {
                actualSum += num;
            }
            return expectedSum - actualSum;
        }

        // Complexity:
        // TC: O (n)
        // SC: O (1)
    }
}
