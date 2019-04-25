using System;

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
