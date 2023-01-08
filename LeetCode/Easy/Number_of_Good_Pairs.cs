using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Number_of_Good_Pairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int x = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        x++;
                    }
                }
            }
            return x;
        }
    }
}
