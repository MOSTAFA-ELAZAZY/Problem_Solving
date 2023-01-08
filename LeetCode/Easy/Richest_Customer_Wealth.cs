using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Richest_Customer_Wealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int x = 0;
            int z = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                z = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    z += accounts[i][j];

                }
                if (x < z)
                {
                    x = z;
                }
            }
            return x;
        }
    }
}
