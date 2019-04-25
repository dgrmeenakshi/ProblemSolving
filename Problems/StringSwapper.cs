using System;

namespace ProblemSolving.Problems
{
   public class StringSwapper
    {
        public static void Swap(string a, string b)
        {
            Console.Write("Before Swapping a : {0} , b : {1}", a, b);
            a = string.Concat(a, b); 
            b = a.Substring(0, a.Length - b.Length);
            a = a.Substring(b.Length);


            Console.Write("\nAfter Swapping a : {0} , b : {1}", a, b);
        }
    }
}
