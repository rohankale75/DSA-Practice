namespace DSAStriver._3._Strings.Basic_Problems
{
    public class Anagrams
    {
        // 6️ Check if Two Strings Are Anagrams(Basic Version)
        // Problem

        // Input: "listen", "silent" → true
        // Input: "anagram", "nagaram" => true
        // Input: "rat", "car" => false

        // What you learn

        // Character counting

        // Comparison logic

        // Pattern: Frequency array

        public static bool AreAnagrams(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach (char ch in s)
            {
                if (!freq.ContainsKey(ch)) freq[ch] = 1;
                else freq[ch]++;
            }

            foreach (char ch in t)
            {
                if (!freq.ContainsKey(ch)) return false;
                freq[ch]--;

                if (freq[ch] < 0) return false;
            }
            return true;
        }
    }
}
