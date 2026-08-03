namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class CheckIfArrayIsSortedOrNot
    {
        // int[] nums = { 1, 2, 2, 4, 7, 7, 5 };
        public static bool CheckIfArrayIsSorted(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)   // Start from 1st index to compare not from 0th index
            {
                if (nums[i] < nums[i - 1]) return false;
            }
            return true;
        }
    }
}
