namespace DSAStriver._3._Strings.LeetCode
{
    public class LongestCommonPrefix
    {
        #region
        // 14. Longest Common Prefix
        //Easy
        //Topics
        //premium lock icon
        //Companies
        //Write a function to find the longest common prefix string amongst an array of strings.

        //If there is no common prefix, return an empty string "".

        //Example 1:

        //Input: strs = ["flower", "flow", "flight"]
        //Output: "fl"
        //Example 2:

        //Input: strs = ["dog", "racecar", "car"]
        //Output: ""
        //Explanation: There is no common prefix among the input strings.


        //Constraints:

        //1 <= strs.length <= 200
        //0 <= strs[i].length <= 200
        //strs[i] consists of only lowercase English letters if it is non-empty.

        public string LongestCommonPrefixMethod(string[] strs)
        {
            if (strs == null || strs?.Length == 0) return "";

            for (int i = 0; i < strs[0].Length; i++)
            {
                var currentChar = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != currentChar)
                    {
                        return strs[i].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }
    #endregion
    }
}
