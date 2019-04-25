using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems
{
    class ReverseNumbersInArray
    {
        public static void ReverseNumbersInanArray(int[] num)
        {
            List<int> revNumbers = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                revNumbers.Add(Reverse(num[i]));
            }

            foreach (var number in revNumbers)
            {
                Console.WriteLine(num);
            }
        }
        private static int Reverse(int v)
        {
            int rev = 0;
            while (v > 0)
            {
                int mod = v % 10;
                rev = rev * 10 + mod;
                v = v / 10;
            }

            return rev;
        }
    }
}
