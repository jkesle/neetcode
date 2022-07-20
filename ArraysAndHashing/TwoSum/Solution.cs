using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetcode.ArraysAndHashing.TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            var res = new int[2];
            foreach (var (num, index) in nums.Select((num, i) => (num, i)))
            {
                if (dict.TryGetValue(num, out var val))
                {
                    res[0] = index;
                    res[1] = val;
                    break;
                }
                dict.TryAdd(num, val);
            }
            return res;

        }
    }
}
