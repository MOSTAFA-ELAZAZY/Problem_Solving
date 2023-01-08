using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Count_Items_Matching_a_Rule
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;
            for (int i = 0; i < items.Count; i++)
            {

                if (ruleKey.Equals("type") && items[i][0].Equals(ruleValue))
                {

                    count++;
                }
                if (ruleKey.Equals("color") && items[i][1].Equals(ruleValue))
                {
                    count++;
                }
                if (ruleKey.Equals("name") && items[i][2].Equals(ruleValue))
                {

                    count++;
                }

            }
            return count;
        }
    }
}
