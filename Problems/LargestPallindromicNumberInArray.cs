using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems
{
    public class LargestPallindromicNumberInArray
    {
        private static int Reverse(int n)
        {
            int rev = 0;
            while (n > 0)
            {
                var rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }

            return rev;
        }

        private static bool IsPallindrom(int n)
        {
            if (n.Equals(Reverse(n)))
                return true;
            return false;
        }

        private static int LargetPallindrom(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPallindrom(arr[i]))
                {
                    if (arr[i]> max)
                    {
                        max = arr[i];
                    }
                }
            }

            return max;
        }

    }
}
