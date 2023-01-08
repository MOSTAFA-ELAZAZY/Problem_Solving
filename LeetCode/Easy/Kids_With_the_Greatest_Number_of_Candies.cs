using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Kids_With_the_Greatest_Number_of_Candies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> list = new List<bool>();
            int Gridest = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                list.Add(candies[i] + extraCandies >= Gridest);
            }

            return list;
        }
    }
}
