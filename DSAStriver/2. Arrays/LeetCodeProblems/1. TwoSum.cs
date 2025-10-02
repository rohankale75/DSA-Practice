namespace DSAStriver._2._Arrays.LeetCodeProblems
{
    public class TwoSum
    {
        // Demo Array int[] arr = { 10, 20, 4, 7, 5 };

        #region 1. O(n^2) Time Complexity
        public int[] TwoSumArrayBasic(int[] nums, int target) // Returns 1D array, if return type is int[,] => 2D Array
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[0];
        }
        #endregion

        #region 2. O(n) Time Complexity (Efficient one but uses more memory)
        public int[] TwoSumDictionary(int[] nums, int target)
        {
            if (nums.Length < 2) return new int[0];

            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int requiredNumber = target - nums[i];

                if (map.ContainsKey(requiredNumber))
                    return new int[] { map[requiredNumber], i }; // Required Output

                if (!map.ContainsKey(nums[i]))  // avoid duplicate overrides
                    map[nums[i]] = i;
            }
            return new int[0];
        }
        #endregion
    }
}
