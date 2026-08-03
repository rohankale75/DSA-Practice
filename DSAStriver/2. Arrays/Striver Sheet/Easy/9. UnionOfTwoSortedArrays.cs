namespace DSAStriver._2._Arrays.Striver_Sheet.Easy
{
    public class UnionOfTwoSortedArrays
    {
        // Problem: Two Given sorted arrays
        // Make a Union of two sorted arrays
        // Union means combining two arrays but only insert unique values, if value from both arrays match then move to next
        // e.g.
        // arr1 = { 1, 1, 2, 3, 4, 5 }  // length => n1
        // arr2 = { 2, 3, 4, 4, 5, 6 }  // length => n2
        // union = { 1, 2, 3, 4, 5, 6 } // length => (n1 + n2) if both given arrays contain unique elements

        // Always Remember
        // Unique elements ==> HashSet

        #region Brute Force
        public static int[] UnionOfTwoSortedArrayBruteForce(int[] a, int[] b)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                set.Add(a[i]);      // TC: O (n1 log n) => n is length of set for this loop
            }
            for (int i = 0;i < b.Length; i++)
            {
                set.Add(b[i]);      // TC: O (n2 log n) => n is the size / length of set for this loop
            }
            int[] unique = new int[set.Count];
            int j = 0;
            foreach (var item in set)
            {
                unique[j++] = item;  // TC: O (n1 + n2) => combining two arrays, why n1 + n2 coz both given array may contain unique elements hence taking whole length into consideration
            }
            return unique;          // TC: O (n1 + n2)
        }

        // Complexity: 
        // TC: O (n1 log n) + O (n2 log n) + O (n1 + n2) 
        // SC: O (n1 + n2) + O (n1 + n2)

        // Explanation:
        // TC: first O (n1 log n)   for first set loop
        // second O (n2 log n) for second set loop
        // third O (n1 + n2) is to combining two arrays into unique array

        // SC: O (n1 + n2) is used for the external set data structure that we have used
        // second O (n1 + n2) is for external Unique[] Array that we used to combine two given arrays a & b
        #endregion

        #region Optimal Approach (Two Pointers)
        // Sorted Array => Two Pointers
        public static List<int> UnionOfTwoSortedArraysOptimal(int[] a, int[] b)
        {
            // arr1 = { 1, 1, 2, 3, 4, 5 }  // length => n1
            // arr2 = { 2, 3, 4, 4, 5, 6 }  // length => n2
            // union = { 1, 2, 3, 4, 5, 6 } // length => (n1 + n2) if both given arrays contain unique elements

            int n1 = a.Length, n2 = b.Length, i = 0, j = 0;
            List<int> unionAr = new List<int>();

            while (i < n1 && j < n2)
            {
                if (a[i] <= b[j])
                {
                    // add a[i] only if union is empty OR last element is different
                    if (unionAr.Count == 0 || (unionAr[unionAr.Count - 1] != a[i]))
                    {
                        unionAr.Add(a[i]);
                    }
                    i++;
                }
                else
                {
                    // add b[j] only if union is empty OR last element is different
                    if (unionAr.Count == 0 || (unionAr[unionAr.Count - 1] != b[j]))
                    {
                        unionAr.Add(b[j]);
                    }
                    j++;
                }
            }

            // remaining elements of a
            while (i < n1)
            {
                if (unionAr[unionAr.Count - 1] != a[i])
                {
                    unionAr.Add(a[i]);
                }
                i++;
            }

            // remaining elements of b
            while (j < n2)
            {
                if (unionAr[unionAr.Count - 1] != b[j])
                {
                    unionAr.Add(b[j]);
                }
                j++;
            }
            return unionAr;
        }

        // Complexity: 
        // TC: O (n1 + n2)
        // SC: O (n1 + n2)
        #endregion
    }

    public class IntersectionOfTwoSortedArrays
    {
        // a = { 1, 2, 2, 3, 3, 4, 5, 6 }
        // b = { 2, 3, 3, 5, 6, 6, 7 }
        // intersection = { 2, 3, 3, 5, 6 } here repetition is allowed
        // means 3 is present two times in a & b hence two entries of 3 in intersection array

        public static List<int> IntersectTwoSortedArrays(int[] a, int[] b)
        {
            var intersection = new List<int>();
            int n1 = a.Length, n2 = b.Length, i = 0, j = 0;

            while (i < n1 && j < n2)
            {
                if (a[i] == b[j])
                {
                    if (intersection.Count == 0 || intersection[intersection.Count - 1] != a[i])    // duplicate handling
                        intersection.Add(a[i]);
                    i++;
                    j++;
                }
                else if (a[i] < b[j])
                    i++;
                else
                    j++;
            }
            return intersection;

            // Complexity: 
            // TC: O (n1 + n2)
            // SC: O (min(n1 + n2)) 
            
            // for SC: O (min(n1 + n2)) => result contain at most of min of both lengths
        }
    }
}
