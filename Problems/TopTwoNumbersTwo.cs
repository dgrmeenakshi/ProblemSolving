using System;

namespace ProblemSolving.Problems
{
    public class TopTwoNumbers
    {
        //first assign the value of l1 to l2 so that l1 can hold the first maximum value and l2 can hold the second maximum value
        public void FindTopTwoNumbers()
        {
            int[] a = { 10, 20, 3, 17 };
            int l1 = 0;
            int l2 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (l1 < a[i])
                {
                    l2 = l1;
                    l1 = a[i];
                }
                else if (l2 < a[i])
                {
                    l2 = a[i];
                }
            }
            Console.WriteLine("Top two numbers are {0}, {1}", l1, l2);
        }
    }
}
