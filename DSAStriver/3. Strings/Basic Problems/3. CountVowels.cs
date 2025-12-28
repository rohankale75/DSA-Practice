namespace DSAStriver._3._Strings.Basic_Problems
{
    public class CountVowels
    {
        // 3️ Count Vowels in a String
        // Problem

        // Input: "education"
        // Output: 5

        // Pattern: Linear scan
        public static int CountVowelsMethod(string str)
        {
            int count = 0;
            foreach (char ch in str.ToLower())
            {
                if ("aeiou".Contains(ch)) count++;
            }
            return count;
        }
    }
}
