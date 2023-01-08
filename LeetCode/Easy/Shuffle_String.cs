using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Shuffle_String
    {
        public string RestoreString(string s, int[] indices)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] vs1 = new string[indices.Length];
            char[] vs = new char[indices.Length];
            vs = s.ToCharArray();
            for (int i = 0; i < indices.Length; i++)
            {
                vs1[indices[i]] = vs[i].ToString();
            }
            for (int i = 0; i < vs1.Length; i++)
            {
                stringBuilder.Append(vs1[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
