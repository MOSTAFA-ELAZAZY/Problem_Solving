using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Final_Value_of_Variable_After_Performing_Operations
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int number = 0;

            for (int i = 0; i < operations.Length; i++)
            {

                if (operations[i][1].ToString() == "+")
                {
                    number++;

                }
                else
                {
                    number--;
                }
            }
            return number;
        }
    }
}
