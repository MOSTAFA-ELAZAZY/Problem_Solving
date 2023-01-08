using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Delete_Greatest_Value_in_Each_Row
    {
        public int DeleteGreatestValue(int[][] grid)
        {

            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < grid.Length; i++)
            {
                Array.Sort(grid[i]);
            }

            int ans = 0;
            for (int j = n - 1; j >= 0; j--)
            {
                int max = 0;
                for (int i = 0; i < m; i++)
                {
                    max = Math.Max(max, grid[i][j]);
                }

                ans += max;
            }

            return ans;

        }
    }
}
