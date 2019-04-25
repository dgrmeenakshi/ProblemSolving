using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Find the Top two numbers in array and add them : Time Complexity: O(n)
namespace ProblemSolving.Problems
{
    public class LargestPairSumInUnSortedArray
    {
        public static int LargestPairSum(int[] arr)
        {
            int first = arr[0];
            int second = arr[1];
            if (arr[0]>arr[1])
            {
                first = arr[0];
                second = arr[1];
            }
            else
            {
                first = arr[1];
                second = arr[0];
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }

                if (arr[i]>second && arr[i]<first )
                {
                    second = arr[i];
                }
            }

            return first + second;

        }
    }
}
