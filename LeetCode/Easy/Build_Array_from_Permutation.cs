using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
   public class Build_Array_from_Permutation
   {
        public int[] BuildArray(int[] nums)
        {
            int[] vs1 = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                vs1[i] = nums[nums[i]];
            }

            return vs1;
        }
    }
}
