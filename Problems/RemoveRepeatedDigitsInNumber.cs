using System;
using System.Collections.Generic;

namespace ProblemSolving.Problems
{
    public class RemoveRepeatedDigitsInNumber
    {
        public static void RemoveDuplicatesFromArray(int[] n)
        {
            HashSet<int> distnictArray = new HashSet<int>(n);
            foreach (var num in distnictArray)
            {
                Console.Write(num);
            }
        }
    }
}
