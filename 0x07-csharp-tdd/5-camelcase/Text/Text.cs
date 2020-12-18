using System;

namespace Text
{
    /// <summary>
    /// Str class.
    /// </summary>
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (s == null || s == "")
            {
                return 0;
            }
            int c = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    if (i != 0)
                    {
                        c++;
                    }
                }
            }
            return c;
        }
    }
}
