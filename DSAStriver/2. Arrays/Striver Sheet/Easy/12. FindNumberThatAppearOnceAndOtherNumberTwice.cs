using System;
using System.Diagnostics;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class FindNumberThatAppearOnceAndOtherNumberTwice
    {
        // Input:  [4, 1, 2, 1, 2]
        // Output: 4

        // Input:  [2, 2, 1]
        // Output: 1

        #region Brute Force
        public static int SingleNumberBruteForce(int[] nums)
        {
            var map = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (map.ContainsKey(num))
                    map[num]++;
                else
                    map[num] = 1;
            }

            foreach (var pair in map)
            {
                if (pair.Value == 1)
                    return pair.Key;
            }
            return -1;
        }

        // Complexity: 
        // TC: O (n) | SC: O (n)
        #endregion

        #region Optimal Solution (XOR => eXclusive OR)

        #region Explanation for XOR
        // It compares two bits and returns
        // 0 XOR 0 = 0  (same → 0)
        // 1 XOR 1 = 0  (same → 0)
        // 0 XOR 1 = 1  (different → 1)
        // 1 XOR 0 = 1  (different → 1)

        // Simple Rule
        // Same   → 0
        // Different → 1

        // E.g.
        // 4 in binary = 100
        // 1 in binary = 001

        // 4 XOR 1:
        //   100
        //   001
        //   ---
        //   101 = 5

        // 5 XOR 5 = 0
        // Any number XOR itself = 0

        // Why? Every bit is same → every bit gives 0

        // 5 XOR 0 = 5

        // Why? 0 bits don't change anything

        // Now the Problem given
        // Array: [4, 1, 2, 1, 2]

        // Every number appearing TWICE will cancel itself:
        // 1 XOR 1 = 0
        // 2 XOR 2 = 0

        // What remains?
        // 4 XOR 0 XOR 0 = 4

        #endregion

        public static int SingleNumberOptimal(int[] nums)
        {
            int result = 0;
            foreach (var num in nums)
                result ^= num;  // XOR every number together
            return result;
        }

        // Constraints:
        // TC: O (n) | SC: O (1)

        #region Practice
        public void Practice()
        {
            int a = 4, b = 4, result = 0, num = 0;
            Console.WriteLine(a ^ b); // 0

            int c = 4, d = 1;
            Console.WriteLine(c ^ d); // 5

            // ^= means XOR and assign, same as +=
            result ^= num; // same as result = result ^ num
        }
        #endregion

        #endregion
    }
}
