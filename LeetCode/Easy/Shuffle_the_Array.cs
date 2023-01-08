using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Shuffle_the_Array
    {
        public int[] Shuffle(int[] nums, int n)
        {
            {
                List<int> x = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    x.Add(nums[i]);
                    x.Add(nums[n + i]);
                }
                return x.ToArray();
            }
        }
    }
}
