using System;
using System.Linq;

/*
 * 
 *  Constraints:
 *  -1000 <= nums[i] <= 1000
 *  
 *  Solution must use only O(1) extra space
 */




namespace neetcode.TwoPointers.TwoSumII
{
    public class Solution 
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length == 2) return new int[] {1, 2};

            int l = 0, r = nums.Length - 1;

            while (nums[l] + nums[r] != target)
            {
                while (nums[l] + nums[r] < target)
                {
                    l++;
                }

                while (nums[l] + nums[r] > target)
                {
                    r--;
                }
            }

            return new int[] { l + 1, r + 1 };
        }
    }
}
