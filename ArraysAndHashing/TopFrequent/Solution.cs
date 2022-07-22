using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetcode.ArraysAndHashing.TopFrequent
{
    public class Solution
    {
        public int[] TopFrequent(int[] nums, int k)
        {
            List<int>[] buckets = new List<int>[nums.Length + 1];  // highest count is bounded to number of elements, ignoring 0
            var groups = nums.GroupBy(x => x);
            var res = new int[k];

            foreach (var g in groups)
            {
                if (buckets[g.Count()] is null)
                {
                    buckets[g.Count()] = new List<int> { g.Key };
                }
                else
                {
                    buckets[g.Count()].Add(g.Key);
                }
            }

            buckets = buckets.Where(l => l != null).Reverse().ToArray();
            var i = 0;
            foreach (var b in buckets)
            {
                foreach (var j in b)
                {
                    if (i >= res.Length)
                    {
                        return res;
                    }
                    res[i] = j;
                    ++i;
                }
            }

            return res;

        }
    }
}
