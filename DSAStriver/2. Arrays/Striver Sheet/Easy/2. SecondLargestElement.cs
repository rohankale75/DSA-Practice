namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class SecondLargestElement
    {
        // Arr = { 1, 2, 2, 4, 7, 7, 5 }
        #region Second Largest Element

        #region Brute Force
        public static int BruteForceMethod(int[] nums)
        {
            Array.Sort(nums);   // => new arr = { 1, 2, 2, 4 ,5, 7, 7 }
            int largest = nums[nums.Length - 1];    // largest will be at the end of array after sorting of array
            // so start the array from (n - 2) because at (n - 1) is the largest array
            int secondLargest = -1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] != largest)
                {
                    secondLargest = nums[i];
                    break;
                }
            }

            return secondLargest;
        }
        // TC: O (n log n) | SC: O(1)
        #endregion

        #region Better
        public static int BetterSolution(int[] nums)
        {
            int largest = 0, secondLargest = -1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > largest) 
                    largest = nums[i];
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > secondLargest && nums[i] < largest) 
                    secondLargest = nums[i];
            }
            return secondLargest;
        }

        // TC: O(n) + O(n) => O(2n) cause of two for loops | SC: O(1)
        #endregion

        #region Optimal Solution
        public static int OptimalSolution(int[] nums)
        {
            int largest = 0, secondLargest = -1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > largest)
                {
                    secondLargest = largest;
                    largest = nums[i];
                }
                else if (secondLargest < nums[i] && nums[i] < largest)
                {
                    secondLargest = nums[i];
                }
            }
            return secondLargest;

            // TC: O(n) | SC: O(1)
        }
        #endregion


        #endregion

        #region Second Smallest Element

        #endregion
    }
}
