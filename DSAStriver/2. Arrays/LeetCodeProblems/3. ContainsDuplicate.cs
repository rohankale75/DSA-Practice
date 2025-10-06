namespace DSAStriver._2._Arrays.LeetCodeProblems
{
    public class ContainsDuplicate
    {
        public bool ContainsDuplicateElement(int[] array)
        {
            if (array.Length < 1) return false;

            HashSet<int> set = new HashSet<int>();
            foreach (int element in array)
            {
                if (set.Contains(element)) return true;
                set.Add(element);
            }
            return false;
        }
    }
}
