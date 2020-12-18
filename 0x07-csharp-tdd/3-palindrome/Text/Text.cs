
using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines if a string is a palindrome
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            string clean_s = s.ToLower();
            clean_s = Regex.Replace(clean_s, "[^a-z]*", "");
            char[] array = clean_s.ToCharArray();
            Array.Reverse(array);
            string rev_clean_s = new string(array);
            return clean_s == rev_clean_s;
        }
    }
}