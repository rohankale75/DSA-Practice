namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class LeftRotateArrayByOnePlace
    {

        public static int[] LeftRotateArray(int[] nums)
        {
            int temp = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i - 1] = nums[i];
            }
            nums[nums.Length - 1] = temp;
            return nums;
        }

        // Complexity: 
        // TC: O(n) | SC: O(1)

        // Here Space complexity in algorithm used is O(n) and not O(1)
        // Why: Coz we are using the same nums to manipulate and showcase the result in the same array hence O(n)
        // But the same is used hence Space complexity used in the algorithm ==> O(n)
        // But the extra space i.e. used to solve the problem is O(1)
        // i.e. variables used to solve except array

        // =====================================================================================================

        // Output

        // // Left rotate by 1 should give:
        // [1,2,3,4,5] → [2,3,4,5,1]
    }
}
