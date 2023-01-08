using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Sum_of_All_Odd_Length_Subarrays
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int Count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Count += arr[i];
                Count += COuntOfSubArray(arr, i);
            }
            return Count;
        }

        public int COuntOfSubArray(int[] vs, int w)
        {
            int count = 0;
            int j = w + 2;
            int subCount = 0;

            for (int i = j; i < vs.Length; i++)
            {
                subCount = 0;

                for (int q = w; q <= j; q++)
                {
                    subCount += vs[q];
                }
                count += subCount;
                if (j + 2 <= vs.Length - 1)
                {
                    j += 2;

                }
                else break;
            }
            return count;
        }
    }
}
