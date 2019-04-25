using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems
{
    public class CountPairsWithGivenSumInArray
    {
        // Time Complexity = O(n)^2
        public static int GetPairsCountWith(int[] inputArray, int sum)
        {
            int Count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {

                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (i != j && inputArray[i] + inputArray[j] == sum)
                    {

                        Count++;
                        string pair = "(" + inputArray[i] + "," + inputArray[j] + ")";
                        Console.WriteLine(pair);
                    }
                }
            }

            return Count;
        }
        // Time Complexity - O(n)
        public static int CountPairstWithNComplexity(int[] inputArray, int sum)
        {
            Dictionary<int, int> dc = new Dictionary<int, int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (dc.ContainsKey(inputArray[i]))
                {
                    dc[inputArray[i]]++;
                }
                else
                {
                    dc.Add(inputArray[i], 1);
                }
            }

            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int find = sum - inputArray[i];
                if (dc.ContainsKey(find))
                {
                    count = count + dc[find];
                    
                }
                if (sum - inputArray[i] == inputArray[i])
                {
                    count--;
                }
            }

            return count / 2;
        }
        // This approach won't work for duplicates in an array O(nlogn).
        // Sorted Array
        public static int GetCountAndPairsInArray(int[] inputArray, int sum)
        {
            int low = 0;
            int high = inputArray.Length - 1;
            int count = 0;
            while (low < high)
            {
                if (inputArray[low] + inputArray[high] > sum)
                {
                    high--;
                }
                else if (inputArray[low] + inputArray[high] < sum)
                {
                    low--;
                }
                else if (inputArray[low] + inputArray[high] == sum)
                {
                    Console.WriteLine("(" + inputArray[low] + "," + inputArray[high] + ")");
                    count++;
                    low++;
                    high--;
                }
            }
            return count;
        }
    }
}
