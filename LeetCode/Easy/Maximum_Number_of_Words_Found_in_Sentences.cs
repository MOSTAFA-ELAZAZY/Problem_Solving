using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Maximum_Number_of_Words_Found_in_Sentences
    {
        public int MostWordsFound(string[] sentences)
        {
            int x = 0;

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Split().Length > x)
                {
                    x = sentences[i].Split().Length;
                }
            }
            return x;
        }
    }
}
