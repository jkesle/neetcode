using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace neetcode.TwoPointers.ValidPalindrome
{
    public class Solution
    {
        public bool ValidPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s.Trim())) return true;
            s = s.ToLower();
            int l = 0, r = s.Length - 1;

            while (l < r)
            {
                while (!Char.IsLetterOrDigit(s[l]))
                {
                    l++;
                    if (l >= s.Length) return true; // if s is only non alphanumeric chars, return true;
                }
                while (!Char.IsLetterOrDigit(s[r]))
                {
                    r--;
                }
                if (s[l] != s[r]) return false;
                l++;
                r--;

            }

            return true;
        }
    }
}