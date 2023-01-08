using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Decompress_Run_Length_Encoded_List
    {
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> vs = new List<int>();
            for (int i = 0; (2 * i + 1) < nums.Length; i++)
            {

                int j = 0;
                while (j++ < nums[2 * i]) vs.Add(nums[2 * i + 1]);

            }
            return vs.ToArray();
        }
    }
}
