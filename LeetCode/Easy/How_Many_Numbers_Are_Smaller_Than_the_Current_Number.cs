using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class How_Many_Numbers_Are_Smaller_Than_the_Current_Number
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] x = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int CountOfNumbers = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i && nums[i] > nums[j])
                    {
                        CountOfNumbers++;
                    }
                }
                x[i] = CountOfNumbers;
            }

            return x;
        }
    }
}
