namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class MoveZerosToEnd
    {
        // int[] arr = { 1, 0, 2, 3, 2, 0, 0, 4, 5, 1 }

        #region Brute Force
        public static int[] MoveZeroToEndBruteForce(int[] nums)
        {
            int j = 0;
            int[] temp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    temp[j] = nums[i];  // temp[] will hold non zero elements
                    j++;
                }
            }
            // can skip below 2 loops as we have achieved the output in the first loop's temp[] itself

            for (int i = 0; i < temp.Length; i++)
            {
                nums[i] = temp[i];  // this will store non-zero numbers to the start
            }
            for (int i = temp.Length; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            return nums;

            // Complexity
            // Time: O (n) + O (x), O (n - n) => O(2n)
            // Spcae: O(n) => O (N)
        }
        #endregion

        #region Optimal Solution
        // Here we will loop through the array once, will take two indexes, i (for non-zero elements) and j (for zero elements)
        // j will always point at 0 value
        // will move i through the array to check number is a non-zero
        // if j having value = 0, then will swap it with i value, j++, 
        // i++ always coz it needs to iterate through whole array
        // if j = -1 for whole array, then that array contains non-zero elements only

        public static int[] MoveZeroToEndOptimal(int[] nums)
        {
            int j = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    j = i;
                    break;
                }
            }
            if (j == -1)    // If array has non-zero elements, then below loop will break and will give index out of bound exception for nums[j] i.e. nums[-1]
                return nums;

            for (int i = j + 1; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                    j++;
                }
            }
            return nums;
        }

        // Complexity:
        // TC: O (n) | SC: O (1)

        // first loop needs to travel length x until it finds 0 hence O (x)
        // second loop needs to travel from x to nums.length hence O (n - x)
        // Overall TC: O (x) + O (n - x) => O(n)
        #endregion
    }
}
