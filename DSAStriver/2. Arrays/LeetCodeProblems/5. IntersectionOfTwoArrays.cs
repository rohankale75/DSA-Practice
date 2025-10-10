namespace DSAStriver._2._Arrays.LeetCodeProblems
{
    public class IntersectionOfTwoArrays
    {
        //  Example 1:

        //  Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
        //  Output: [2, 2]

        //  Example 2:

        //  Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
        //  Output: [4, 9]
        //  Explanation: [9, 4] is also accepted.

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            List<int> result = new List<int>();

            // Step 1: Store frequency of elements in nums1
            foreach (int num in nums1)
            {
                if (!freq.ContainsKey(num))
                    freq[num] = 1;
                else
                    freq[num]++;
            }

            // Step 2: Check elements from nums2
            foreach (int num in nums2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    result.Add(num);
                    freq[num]--; // Decrease count
                }
            }

            return result.ToArray();
        }
    }
}
