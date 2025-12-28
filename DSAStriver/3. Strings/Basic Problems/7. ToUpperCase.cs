namespace DSAStriver._3._Strings.Basic_Problems
{
    public class ToUpperCase
    {
        // 7 Convert String to Uppercase / Lowercase (Manual)
        // Problem

        // Input: "Hello"
        // Output: "HELLO"

        // What you learn

        // ASCII values

        // Character manipulation

        // Pattern: Character arithmetic

        public static string ToUpperCaseMethod(string str)
        {
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch[i] = (char)(ch[i] - 32);
                }
            }
            return new string(ch);
        }
    }
}
