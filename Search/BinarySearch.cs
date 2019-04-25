using System;

namespace ProblemSolvings
{
    public class BinarySearch
    {
        public static void Search()
        {
            int[] dataSet = { 10, 20, 30, 40, 50 };
            int start = 0, end = 4, mid;
            int find = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;

                if (dataSet[mid] == find)
                {
                    Console.Write("The indexs of " + find + " is : " + mid);
                    break;
                }
                else if (dataSet[mid] < find)
                {
                    start = mid + 1;
                    mid = (start + end) / 2;
                }
                else if (dataSet[mid] > find)
                {
                    end = mid - 1;
                    mid = (start + end) / 2;
                }
            }
            if (start > end)
            {
                Console.Write("Element is not present in the list");
            }
        }

    
    }
}
