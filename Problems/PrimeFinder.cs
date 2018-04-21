using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems
{
    public class PrimeFinder
    {
        /* Find list of prime numbers between a given range**/
        bool isPrime = true;
        public void FindPrimeNumbersBetween(int startRange , int endRange)
        {
            for (int i = startRange; i <= endRange; i++)
            {
                for (int j = 2; j < i / 2; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("\t"+i);
                }
                isPrime = true;
            }
            Console.ReadLine();
        }
        
    }
}
