using System;

namespace ProblemSolving.Sort
{
    /// <summary>
    /// Bubble Sort
    /// Arranging the numbers in Ascending Order by Swapping the adjacent elements if they are in wrong order.
    /// </summary>
    public class BubbleSort
    {
        public void Sort(int[] input)
        {
            int n = input.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (input[j] < input[j + 1])
                    {
                        Swap(input, j, j + 1);
                    }

                }
            }
            PrintArray(input);
         }
        private static void Swap(int[] array, int index, int nextElementIndex)
        {
            array[index] = array[index] + array[nextElementIndex];
            array[nextElementIndex] = array[index] - array[nextElementIndex];
            array[index] = array[index] - array[nextElementIndex];

        }

        private void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
