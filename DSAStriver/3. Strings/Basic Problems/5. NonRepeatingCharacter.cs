namespace DSAStriver._3._Strings.Basic_Problems
{
    public class NonRepeatingCharacter
    {
        // 5️ Find First Non-Repeating Character

        // Problem

        // Input: "aabbcd"
        // Output: 'c'

        // What you learn

        // Frequency counting
        // Two-pass logic

        // Pattern: HashMap + scan

        public static char NonRepeatingCharacterMethod(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            // Count Frequency
            foreach (char ch in str)
            {
                if (!map.ContainsKey(ch)) map[ch] = 1;
                else map[ch]++;
            }

            // Find 1st character with Count = 1
            foreach (char ch in str)
            {
                if (map[ch] == 1) return ch;
            }
            return '\0';
        }
    }
}
