using System;
using System.Collections.Generic;

namespace ProblemSolving.Problems
{
    /*Input = abbaccdbac and Output = a3b3c3d1*/
    public class CharacterCounter
    {
        public static void CountOfCharactersInString()
        {
            string input = "Meenakshi";
            Dictionary<string, int> temp = new Dictionary<string, int>();
            foreach (var character in input)
            {
                if (temp.ContainsKey(character.ToString()))
                    temp[character.ToString()]++;
                else
                    temp.Add(character.ToString(), 1);
            }
            foreach (KeyValuePair<string, int> kvp in temp)
            {
                Console.Write("{0}{1}", kvp.Key, kvp.Value);
            }
        }
    }
}
