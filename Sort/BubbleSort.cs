using System;

namespace ProblemSolving.Sort
{
   public class BubbleSort
    {
        public void Sort(int[] input)
        {
            int size = input.Length;
            for (int k = 0; k < size - 1; k++)
            {
                for (int i = 0; i < size - 2; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        Swap(input, i, i+1);
                    }
                    
                }
            }
     
        }

        private static void Swap(int[] array, int index, int nextElementIndex)
        {
            array[index] = array[index] + array[nextElementIndex];
            array[nextElementIndex] = array[index] - array[nextElementIndex];
            array[index] = array[index] - array[nextElementIndex];
        }
    }
}
