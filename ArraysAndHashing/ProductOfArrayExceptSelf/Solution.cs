using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetcode.ArraysAndHashing.ProductOfArrayExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            var zeroes = (0, 0);
            var product = 1;
            var index = 0;

            foreach (var n in nums)
            {
                if (n == 0)
                {
                    zeroes.Item1++;
                    if (zeroes.Item1 > 1)
                    {
                        Array.Fill(result, 0);
                        return result;
                    }
                    zeroes.Item2 = index;
                    index++;
                    continue;
                }
                product *= n;
                index++;
            }

            index = 0;

            if (zeroes.Item1 > 0)
            {
                Array.Fill(result, 0);
                result[zeroes.Item2] = product;
                return result;
            }

            foreach (var n in nums)
            {
                result[index++] = (int)(product * Math.Pow(n, -1));
            }

            return result;
        }
    }
}
