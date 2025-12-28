using DSAStriver._3._Strings.Basic_Problems;

namespace DSAStriver._3._Strings
{
    public class Strings
    {
        public void StringMethods()
        {
            #region Basic Methods
            Console.WriteLine("Reverse String of Hello is: " + ReverseString.ReverseStringMethod("hello"));
            Console.WriteLine("Is String Madam Palindrome? " + PalindromeString.PalindromeStringMethod("madam"));
            Console.WriteLine("Count Vowels in education: " + CountVowels.CountVowelsMethod("education"));

            Dictionary<char, int> dict = CountOccuranceOfEachCharacter.CountEachCharacterOccuranceMethod("aabcc");
            Console.WriteLine("Given string: aabcc");
            foreach (var map in dict)
            {
                Console.WriteLine("Character: " + map.Key + " Count: " + map.Value);
            }

            Console.WriteLine("Non repeating character in string (aabbcd) is: " + NonRepeatingCharacter.NonRepeatingCharacterMethod("aabbcd"));

            Console.WriteLine("Are strings anagram: 1. listen, 2. silent: " + Anagrams.AreAnagrams("listen", "silent"));

            Console.WriteLine("String hello to uppercase: " + ToUpperCase.ToUpperCaseMethod("hello"));
            #endregion
        }
    }
}
