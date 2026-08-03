namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class LargestElement
    {
        #region Brute Force
        // nums = { 3, 2, 1, 5, 2 }
        public static int LargestElement1(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length - 1];
            // After sorting, largest element will be at the far end of the Array
        }
        // Complexity
        // Time: O (n logn) | Space: O (1) 
        // Every sorting type like Merge sort, Quick sort will time Time Complexity (TC) of O (n log n)
        #endregion

        #region Optimal Solution
        public static int LargestElement2(int[] nums)
        {
            int largestNo = 0;
            // If array contains -ve elements then take largestNo = int.MinValue and if contains +ve then largestNo = 0, for second largest 
            // SLarge = either int.MinValue or -1 (if we have to return -1 as default value if records not matched)

            for (int i = 0; i < nums.Length; i++)
            {
                if (largestNo < nums[i])
                {
                    largestNo = nums[i];
                }
            }
            return largestNo;
        }

        // Complexity: 
        // Time: O (n) | Space: O (1)
        #endregion
    }
}
