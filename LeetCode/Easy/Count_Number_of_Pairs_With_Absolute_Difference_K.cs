using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Count_Number_of_Pairs_With_Absolute_Difference_K
    {
        public int CountKDifference(int[] nums, int k)
        {
            int Count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] - nums[j] == k)
                        Count++;
                }
            }
            return Count;
        }
    }
}
