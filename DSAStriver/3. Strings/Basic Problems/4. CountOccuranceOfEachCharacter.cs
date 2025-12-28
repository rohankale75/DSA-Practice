namespace DSAStriver._3._Strings.Basic_Problems
{
    public class CountOccuranceOfEachCharacter
    {
        public static Dictionary<char, int> CountEachCharacterOccuranceMethod(string str)
        {
            // 4️ Count Occurrence of Each Character
            // Problem

            //Input: "aabcc"
            //Output: a = 2, b = 1, c = 2

            // Pattern: Frequency counting
            Dictionary<char, int> map = new Dictionary<char, int>();
            int count = 0;
            foreach (char ch in str)
            {
                if (!map.ContainsKey(ch)) map[ch] = 1;
                else map[ch]++;
            }
            return map;
        }
    }
}
