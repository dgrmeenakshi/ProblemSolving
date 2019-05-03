using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems
{
    public class RemoveDuplicatesFomArray
    {
        // For Sorted Array- o(nlogn)
        public static int[] RemoveDuplicatesByCheckingPreviousElement(int[] arr)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i]!= arr[i+1])
                {
                    lst.Add(arr[i]);
                }
            }
            lst.Add(arr[arr.Length-1]);
            return lst.ToArray();
        }

        // For Unsorted Array- Using a HashSet- o(n)
        public static int[] RemoveDuplicatesUsingHashSet(int[] array)
        {
            HashSet<int> distinct = new HashSet<int>();
            foreach (var number in array)
            {
                if(!distinct.Contains(number))
                distinct.Add(number);
            }

            return distinct.ToArray();
        }
    }
}
