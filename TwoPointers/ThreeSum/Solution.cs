namespace neetcode.TwoPointers.ThreeSum;

using System;


class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var res = new List<IList<int>>();

        for (int i = 0; nums[i] <= 0 && i < nums.Length - 2;)
        {
            var target = nums[i] * -1;
            int l = i+1, r = nums.Length -1;
            while(l < r)
            {
                var sum = nums[l] + nums[r];
                if (sum < target)
                {
                    l++;
                }
                if (sum > target)
                {
                    r--;
                }
                if (sum == target)
                {
                    res.Add(new List<int> {nums[i], nums[l], nums[r]});
                    while (l < r && nums[l] == nums[l+1])
                    {
                        l++;
                    }
                    l++;
                    while (r > l && nums[r] == nums[r-1])
                    {
                        r--;
                    }
                    r--;
                }
            }
            while (i < nums.Length -2 && nums[i] == nums[i+1])
            {
                i++;
            }
            i++;
        }
        return res;
    }
}
