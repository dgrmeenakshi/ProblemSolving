using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvings
{
    public class Anagram
    {
        public static void AnagramProblem(string a, string b)
        {
        if (a.Length == b.Length)
            {
                if (Sort(a) == Sort(b))
                {
                    Console.Write("Anagram");

                }
                else
                {
                    Console.Write("Not an angram");
                }
            }
        }
        public static string Sort(string str)
        {
            char[] c = str.ToCharArray();
            Array.Sort(c);
            return new string(c);

        }
	
    }
}
