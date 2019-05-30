using System;
using System.Collections;
using System.Runtime.InteropServices;
using ProblemSolving.Problems;
using ProblemSolving.Sort;

namespace ProblemSolving
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //HighestConsicutiveStringFinder obj = new HighestConsicutiveStringFinder();
            //obj.HighestConsecutiveString();

            //BubbleSort sort = new BubbleSort();
            //int[] array = {5, 1, 4, 2, 8};
            //sort.Sort(array);

            //int[] a = { 1, 5, 7, -1, 5 };
            //Console.WriteLine(CountPairsWithGivenSumInArray.GetPairsCountWith(a, 6));
            //Console.WriteLine("-----------------");

            //Console.WriteLine("No. of Pairs {0}",CountPairsWithGivenSumInArray.CountPairstWithNComplexity(a, 6));
            //Console.WriteLine(CountPairsWithGivenSumInArray.GetCountAndPairsInArray(a,6));

            //Console.WriteLine(LargestPairSumInUnSortedArray.LargestPairSum(a));
            //    int[] a = { 1, 2, 3, 4 };
            //int ad = CountSubarraysProductLessThanK.SubarrysCountProductLessThanK(a,10);

            Matrix m = new Matrix();
            int[,] arr = new int[3, 3];
            m.EnterMatrixInts(3, 3, arr);
            m.PrintMatrixDiagonaly(3,3,arr);

            Console.ReadLine();

        }
    }
}

