using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems
{
   public  class PrintTrianglePattern
    { 
        public void TrianglePattern(int input)
        {
            for (int i = 0; i < input; i++)
            {
                for (int j = input; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" * ");
                }

                Console.WriteLine(" ");
            }
        }
    }
}
