using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Truncate_Sentence
    {
        public string TruncateSentence(string s, int k)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] vs = s.Split(' ');
            for (int i = 0; i < k; i++)
            {
                if (i > 0)
                {
                    stringBuilder.Append(" " + vs[i]);
                }
                else
                {
                    stringBuilder.Append(vs[i]);
                }

            }

            return stringBuilder.ToString();
        }
    }
}
