using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace neetcode.TwoPointers.ValidPalindrome
{
    public class Solution
    {
        public bool ValidPalindrome(string s)
        {
            var regex = new Regex("[^A-Za-z0-9]");
            s = new string(s.ToCharArray().Where(c => !regex.IsMatch(c.ToString())).ToArray());
            Console.WriteLine(s);
            return new string(s.Reverse().ToArray()) == s;
        }
    }
}