using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems
{
  public class ArrayToDigit
    {
        public static int ConvertArrayToDigit(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i] * Convert.ToInt32(Math.Pow(10, (arr.Length - 1) - i));
            }
            return sum;
        }
    }
}
