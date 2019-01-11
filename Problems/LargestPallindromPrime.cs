using System;


namespace ProblemSolving.Problems
{
     public class LargestPallindromPrime
    {

        public int LargestPallindromPrimeinAnArray(int[] array)
        {
            int[] primes = PrimesinanArray(array);
            int[] pallindroms = PallindromsInAnArray(primes);
            int Max = 0;
            for (int i = 0; i < pallindroms.Length; i++)
            {
                if (Max < pallindroms[i])
                    Max = pallindroms[i];
            }

            return Max;
        }

        private int[] PrimesinanArray(int[] arr)
        {
          int[] tempArray = new int[5];
           
            for (int i = 0; i < arr.Length; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < 12; j++) // To Do use appropriate array
                {
                    if (arr[i] != j && arr[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                 }

                if (isPrime)
                    tempArray[i] = arr[i];
            }

            return tempArray;
      }


        private int[] PallindromsInAnArray(int[] arr)
        {
            int [] a = new int[5];// To Do - Optimize way to not use empty array
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(Reverse(arr[i])))
                {
                    a[i] = arr[i];
                }
            }

            return a;
        }

        private int Reverse(int v)
        {
            int rev = 0;
            while (v>0)
            {
                int mod = v % 10;
                rev = rev * 10 + mod;
                v = v / 10;
            }

            return rev;
        }

        public int[] ReverseNumbersInanArray(int[] num)
        {
            int [] arr = new int[5]; // To Do Find an optimize way to not use an empty array
            
            for (int i = 0; i < num.Length; i++)
            {
                int rev = 0;
                while (num[i] > 0)
                {
                    int mod = num[i] % 10;
                    rev = (rev * 10) + mod;
                    num[i] = num[i] / 10;
                }

               arr[i] = rev;
            }

            return arr;
        }

        
    }
}
