using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetcode.ArraysAndHashing.IsAnagram
{
    public class Solution
    {
        private Action<char, int, Dictionary<char, int>> AddToDict = (c, i, dict) => 
        {
            if (!dict.TryAdd(c, i))
            {
                dict[c] = dict[c] + i;
            }
        };

        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
            {
                AddToDict(s[i], 1, dict);

                AddToDict(t[i], -1, dict);
            }

            return !dict.Values.Where(x => x != 0).Any();
        }
    }
}