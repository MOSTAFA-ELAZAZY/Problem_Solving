using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Global_Classes
{
    class Binary_Search
    {
        public int BinarySearchDisplay(int[] arr, int key)
        {
            int Low = 0;
            int High = arr.Length - 1;
            while (Low <= High)
            {
                int mid = (Low + High);
                int guess = arr[mid];
                if (guess == key) return mid;
                if (guess > key)
                {
                    High = mid - 1;
                }
                else
                {
                    Low = mid + 1;
                }

            }
            return -1;
        }
    }
}
