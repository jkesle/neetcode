using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetcode.ArraysAndHashing.GroupAnagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs) //TODO: optimize
        {

            var res = new List<IList<string>>();
            strs = strs.OrderBy<string, int>(s => s.Count()).ToArray();
            var dict = new Dictionary<string, int>();
            var index = 0;

            foreach (var st in strs)
            {
                var s = new string(st.ToLower().ToCharArray().OrderBy(c => (byte)c).ToArray());
                if (!dict.TryAdd(s, index))
                {
                    res[dict[s]].Add(st);
                }
                else
                {
                    res.Add(new List<string>(new string[] { st }));
                    index++;
                }
            }
            return res;
        }
    }
}
