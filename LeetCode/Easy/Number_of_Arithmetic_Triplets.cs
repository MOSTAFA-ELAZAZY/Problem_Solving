using LeetCode.Global_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Number_of_Arithmetic_Triplets
    {
        private readonly Binary_Search _Search;
        public Number_of_Arithmetic_Triplets(Binary_Search search)
        {
            this._Search = search;
        }
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            int j = 0;
            int k = 0;
            int count = 0;
            for (int w = 0; w < nums.Length; w++)
            {
                int c = nums[w] + diff;
                int f = (nums[w] + diff) + diff;
                j = _Search.BinarySearchDisplay(nums, c);
                k = _Search.BinarySearchDisplay(nums, f);
                if (k > 0 && j > 0)
                {
                    count++;
                }
            }

            return count;
        }


      
    }
}
