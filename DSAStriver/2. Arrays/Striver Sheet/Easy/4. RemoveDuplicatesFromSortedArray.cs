namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        // Q. Remove duplicates from the Sorted Array and return the length of Unique elements Array

        // int[] nums = { 1, 1, 2, 2, 3, 3, 3 };
        #region Brute Force (Using SET)
        public static int RemoveDuplicateBruteForceMethod(int[] nums)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);   // This will add only unique elements into the set and this will be O (n logn)
            }

            var index = 0;
            foreach (var item in set)
            {
                nums[index] = item;
                index++;
            }
            return index;
        }

        // Constraints
        // TC: O (n logn) + O (n) | Space: O(n)

        // Why Space: O(n) => Because there is a possibility that every element from the given array have uniqueness
        #endregion

        #region Optimal Solution (Two Pointers: Coz Array is Sorted)
        public static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                // Explanation: If nums[i] number is != its next number i.e. nums[j] then its a unique number 
                // If nums[i] == nums[j] then both are duplicate to each other hence move to next number
                if (nums[j] != nums[i])
                {
                    nums[i + 1] = nums[j];
                    i++;
                }
            }
            return ++i;     // OR return i + 1;
        }

        // Constraints
        // TC: O (n) | Space: O (1)
        #endregion
    }
}
