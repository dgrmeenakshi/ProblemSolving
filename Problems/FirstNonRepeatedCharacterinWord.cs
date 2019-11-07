using System;
using System.Collections.Generic;

namespace ProblemSolving.Problems
{
    public class FirstNonRepeatedCharacterinWord
    {
        public static void FirstNonRepeatedCharinWord(string s)
        {
            var dc = new Dictionary<string, int>();
            foreach (var cr in s)
                if (dc.ContainsKey(cr.ToString()))
                    dc[cr.ToString()]++;
                else
                    dc.Add(cr.ToString(), 1);

            foreach (var kvp in dc)
            {
                if (kvp.Value == 1)
                {
                    Console.WriteLine($"First non repeated is {kvp.Key}");
                    break;
                }

                Console.WriteLine("All characters are repeating");
            }
        }
    }
}