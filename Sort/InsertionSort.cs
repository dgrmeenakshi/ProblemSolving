using System;

namespace ProblemSolving.Sort
{
    public class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            int size = array.Length;
            for (int index = 0; index < size; index++)
            {
                for (int nextElementIndex = index + 1; nextElementIndex < size; nextElementIndex++)
                {
                    if (array[index] > array[nextElementIndex])
                    {
                        Swap(array, index, nextElementIndex);
                    }
                }

            }

            return array;
        }

        private static void Swap(int[] array, int index, int nextElementIndex)
        {
            array[index] = array[index] + array[nextElementIndex];
            array[nextElementIndex] = array[index] - array[nextElementIndex];
            array[index] = array[index] - array[nextElementIndex];

        }




    }
}