namespace neetcode.ArraysAndHashing.ContainsDuplicate;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Solution
    {
    public bool ContainsDuplicate(int[] nums) => new HashSet<int>(nums).Count() < nums.Length;
    }

