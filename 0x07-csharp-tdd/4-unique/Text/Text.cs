using System;

namespace Text
{
    /// <summary>
    /// Str class.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character of a string.
        /// </summary>
        public static int UniqueChar(string s)
        {
            if (s == null || s == "")
            {
                return -1;
            }
            char c = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (c != s[i])
                {
                    return i;
                }
                c = s[i];
            }
            return -1;
        }
    }
}
