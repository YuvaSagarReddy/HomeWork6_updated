using System;
namespace HomeWork6
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            int lenHaystack = haystack.Length;
            int lenNeedle = needle.Length;

            for (int i = 0; i <= lenHaystack - lenNeedle; i++)
            {
                if (haystack.Substring(i, lenNeedle) == needle)
                {
                    return i;
                }
            }

            return -1;
        }
    }

}

