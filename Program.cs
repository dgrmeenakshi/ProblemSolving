using System;
using ProblemSolving.Problems;
using ProblemSolving.Sort;

namespace ProblemSolving
{
  public  class Program
    {
      public  static void Main(string[] args)
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
            int[] a = {4,1,2,3,1,2,3};

            RemoveRepeatedDigitsInNumber.RemoveDuplicatesFromArray(a);



            Console.ReadLine();

        }
    }
  }

