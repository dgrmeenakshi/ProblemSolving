using System;

namespace ProblemSolving.Sort
{
    /// <summary>
    ///     Insertion Sort builds the final sorted array one item at a time.
    ///     Select the first element and compare with all the remaining elements in array, Swap if order is incorrect.
    /// </summary>
    public class InsertionSort
    {
        public static void Sort(int[] array)
        {
            var size = array.Length;
            for (var index = 0; index < size; index++)
            for (var nextElementIndex = index + 1; nextElementIndex < size; nextElementIndex++)
                if (array[index] > array[nextElementIndex])
                    Swap(array, index, nextElementIndex);

            PrintArray(array);
        }

        private static void Swap(int[] array, int index, int nextElementIndex)
        {
            array[index] = array[index] + array[nextElementIndex];
            array[nextElementIndex] = array[index] - array[nextElementIndex];
            array[index] = array[index] - array[nextElementIndex];
        }

        private static void PrintArray(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++) Console.Write(arr[i]);
        }
    }
}
