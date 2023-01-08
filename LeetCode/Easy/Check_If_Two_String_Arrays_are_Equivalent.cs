using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Check_If_Two_String_Arrays_are_Equivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            StringBuilder x1 = new StringBuilder();
            StringBuilder x2 = new StringBuilder();

            for (int i = 0; i < word1.Length; i++)
            {
                x1.Append(word1[i]);
            }

            x2.Append(ArrayStringsAreEqual2(word2));

            if (x1.Equals(x2))
            {
                return true;
            }

            return false;
        }

        public StringBuilder ArrayStringsAreEqual2(string[] word2)
        {
            StringBuilder x1 = new StringBuilder();

            for (int i = 0; i < word2.Length; i++)
            {
                x1.Append(word2[i]);
            }
            return x1;
        }
    }
}
