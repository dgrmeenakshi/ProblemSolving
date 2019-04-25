using System;

namespace ProblemSolving.Problems
{
    class MissingElementFinder
    {
        /* Sum of N natural nubers is 1 + 2 +3 ... N . if array have 7 elements in the range from 1 to 8 then n=8
         * */
        public static void GetMissingElementInArray()
        {
            int[] a = { 1, 2, 4, 5 };
            int n = a.Length + 1;
            int Sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Sum = Sum + a[i];
            }

            int sumofNatuarlNumbers = (n * (n + 1)) / 2;
            int missingNumber = sumofNatuarlNumbers - Sum;
            Console.Write("Missing No. is :" + missingNumber);
            Console.ReadLine();

        }
    }
}
