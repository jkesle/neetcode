using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace neetcode.TwoPointers.ValidPalindrome
{
    public class Solution
    {
        //public bool ValidPalindrome(string s) //unoptimized
        //{
           // var regex = new Regex("[^A-Za-z0-9]");
            //s = new string(s.ToLower().ToCharArray().Where(c => !regex.IsMatch(c.ToString())).ToArray());
            //return new string(s.Reverse().ToArray()) == s;
        //}

        public bool ValidPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;
            var regex = new Regex("[\\W_]");
            s = new string(s.ToLower().ToCharArray().Where(c => !regex.IsMatch(c.ToString())).ToArray()); //this could be optimized

            while (l <= r)
            {
                if (s[l++] != s[r--])
                {
                    return false;
                }
            }

            return true;
        }
    }
}