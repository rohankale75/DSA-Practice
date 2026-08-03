using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class MaximumConsecutiveOnes
    {
        public static int MaxConsecutiveOnes(int[] nums)
        {
            // { 1, 1, 0, 1, 1, 1, 0, 1, 1 }
            // Find the count for max consecutive ones (1s)
            // count = 3 (because middle pair 1, 1, 1 has max consecutive ones
            int count = 0, max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                    if (count > max)
                        max = count;

                    // OR
                    // max = Math.Max(max, count);
                }
                else
                    count = 0;
            }
            return max;
        }

        // Complexity: 
        // TC: O (n) | SC: O (1)
    }
}
