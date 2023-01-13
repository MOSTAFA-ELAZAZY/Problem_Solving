using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Unique_Morse_Code_Words
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morseAlphabet = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
                ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
                "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            HashSet<string> uniqueTransformation = new HashSet<string>();

            for (int i = 0; i < words.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in words[i])
                {
                    sb.Append(morseAlphabet[item - 'a']);
                }
                uniqueTransformation.Add(sb.ToString());
            }
            return uniqueTransformation.Count();
        }

    }
}
