namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class LeftRotateArrayByDPlaces
    {
        // int[] arr = { 1, 2, 3, 4, 5, 6, 7 } d = 3
        // i.e. move 1st two places and remaining shift to left

        // Output: { 1, 2, 3, 4, 5, 6, 7 } ==> { 4, 5, 6, 7, 1, 2, 3 } 

        #region Important Concept of Modulo (i.e. %)
        // Length of Arr = 7
        // If D = 7 (i.e. places by which we have to left rotate the array
        // if Length = D ==> All the elements will be shifted but will land at the same place again (i.e. No change in the array even after rotating)
        // if Length < D ==> D = 20 ==> 20 = 7 + 7 + 6 
        // i.e. two times left rotated array by 7 which has no impact as array will be the same, so the remaining will be 6 hence need to only rotate array by 6
        // similarly, D = 15 ==> 7 + 7 + 1 => only left rotate array by 1 place only
        // Hence whenever Length < D ==> Use modulo
        // e.g. (Length % D) ==> 20 % 7 = 6 (i.e. left rotate array by 6)
        #endregion

        #region Brute Force
        public static int[] LeftRotateByDPlaces(int[] nums, int d)
        {
            int[] temp = new int[d];
            int len = nums.Length;
            for (int i = 0; i < d; i++)     // TC: O(d)
            {
                temp[i] = nums[i];
            }

            for (int i = d; i < len; i++)   // TC: O(n - d)
            {
                nums[i - d] = nums[i];
            }

            for (int i = len - d; i < len; i++) // TC: O(d)
            {
                nums[i] = temp[i - (len - d)];
            }
            return nums;
        }

        // Complexity:
        // TC: O(d) + O(n - d) + O(d) => O(n + d)
        // SC: O(d) (this is extra space complexity which is temp[])

        // Now optimize this SC to O(1) using Optimal Solution
        #endregion

        #region Optimal Solution
        // { 1, 2, 3, 4, 5, 6, 7 } d = 3
        // rotate 1st half from i = 0 to i = d - 1 i.e. { 1, 2, 3 } => { 3, 2, 1 }

        // rotate 2nd half from i = d to i = n - 1 i.e. { 4, 5, 6, 7 } => { 7 , 6, 5, 4 }
        // now the whole array will be => { 3, 2, 1, 7, 6, 5, 4 }
        // Now reverse the whole array => { 4, 5, 6, 7, 1, 2, 3 } => which is our required output

        // So here, 3 times rotation of Array needs to be done

        public static int[] LeftRotateByDPlacesOptimal(int[] nums, int d)
        {
            ReverseArray(nums, 0, d - 1);
            ReverseArray(nums, d, nums.Length - 1);
            ReverseArray(nums, 0, nums.Length - 1);
            return nums;
        }

        private static int[] ReverseArray(int[] nums, int left, int right)
        {
            int temp = 0;
            while (left <= right)
            {
                temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            }
            return nums;
        }
        #endregion
    }
}
