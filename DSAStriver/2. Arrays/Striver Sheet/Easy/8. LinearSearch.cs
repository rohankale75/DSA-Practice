namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class LinearSearch
    {
        public static int LinearSearchMethod(int[] nums, int target)
        {
            // Q. Find element in an array which equals target value and return its index, else -1
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
