using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.Problems;

namespace ProblemSolving
{
    public class MergeTwoArrayInSortedArray
    {
        // Input - a1= 1,5,7
        //         a2 = 2,4,6,8,10
        //           o/p = 1,2,4,5,6,7,8
        public int[] MergeArray(int[] a, int[] b)
        {
            List<int> lst = new List<int>();

            int i = 0, j = 0, k = 0;

            while (i < a.Length && j < b.Length)
            {
                lst.Add(a[i] < b[j] ? a[i++] : b[j++]);
            }

            while (i < a.Length)
            {
                lst.Add(a[i++]);
            }
            while (j < b.Length)
            {
                lst.Add(b[j++]);

            }
            return lst.ToArray();
        }
    }
}

