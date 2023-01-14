using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Count_the_Number_of_Consistent_Strings
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            int num = words.Length;
            int total = 0;
            for (int i = 0; i < words.Length; i++)
            {
                foreach (var c in words[i])
                {
                    if (!allowed.Contains(c))

                    {
                        total++;
                        break;
                    }
                }
            }
            return num - total;
        }
    }
}
