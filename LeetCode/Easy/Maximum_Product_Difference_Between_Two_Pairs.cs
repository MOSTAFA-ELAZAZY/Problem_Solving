using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Maximum_Product_Difference_Between_Two_Pairs
    {
        public int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);
            return (nums[nums.Length - 1] * nums[nums.Length - 2]) - (nums[0] * nums[1]); ;
        }
    }
}
