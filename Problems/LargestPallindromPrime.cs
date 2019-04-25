using System;
using System.Collections;
using System.Collections.Generic;


namespace ProblemSolving.Problems
{
    public class LargestPallindromPrime
    {
        public static int Reverse(int v)
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
        private static IEnumerable<int> GetPrimesInArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < arr[i] / 2; j++)
                {
                    if (arr[i] != j && arr[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    yield return arr[i];
            }


        }
        public static int LargestPallindromPrimeinAnArray(int[] array)
        {
            int max = 0;
            IEnumerable<int> primes = GetPrimesInArray(array);
            foreach (var prime in primes)
            {
                if (prime > max)
                {
                    max = prime;
                }
            }

            return max;
        }
    }
}
