namespace DSAStriver._3._Strings.Basic_Problems
{
    public class ReverseString
    {
        // 1️ Reverse a String
        // Problem

        // Input: "hello"
        // Output: "olleh"

        // Pattern used => Two Pointers

        public static string ReverseStringMethod(string str)
        {
            char[] ch = str.ToCharArray();
            int left = 0, right = ch.Length - 1;

            while (left < right)
            {
                char temp = ch[left];
                ch[left] = ch[right];
                ch[right] = temp;
                left++;
                right--;
            }
            return new string(ch);
        }

        // 2nd solution
        // Pattern: String splitting
        string ReverseWords(string s)
        {
            string[] words = s.Split(' ');
            string result = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }

            return result.Trim();
        }

    }
}
