using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Running_Sum_of_1d_Array
    {
        public int[] RunningSum(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];

            }

            return nums;
        }
    }
}
