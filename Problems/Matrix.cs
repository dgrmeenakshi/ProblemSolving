using System;

namespace ProblemSolving.Problems
{
    public class Matrix
    {
        // Prints the Absolute difference between the Left Diagonal and Right Diagonal of Matrix
        public void EnterMatrixAndPrintDigonalAbsoluteDifference()
        {
            Console.WriteLine("Enter Rows");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Columns");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Matrix");
            int[,] matrix1 = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            PrintMatrix(r, c, matrix1);

            var leftSum = AddLeftDigonal(r, c, matrix1);

            var rightSum = RightDigonalSum(r, c, matrix1);


            var abs = Math.Abs(leftSum - rightSum);
            Console.WriteLine($"The Absolute Difference Between Left Diagonal and Right Diagonal is {abs} ");
        }

        private static int RightDigonalSum(int r, int c, int[,] matrix1)
        {
            int rightSum = 0;
            for (int i = r - 1; i > -1; i--)
            {
                for (int j = c - 1; j > -1; j--)
                {
                    if (i == j)
                    {
                        rightSum = rightSum + matrix1[i, j];
                    }
                }
            }

            return rightSum;
        }

        private static int AddLeftDigonal(int r, int c, int[,] matrix1)
        {
            Console.WriteLine("Add left diagonal ");
            int leftSum = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == j)
                    {

                        leftSum = leftSum + matrix1[i, j];
                    }
                }
            }
            return leftSum;
        }

        private static void PrintMatrix(int r, int c, int[,] matrix1)
        {
            Console.WriteLine("Print Matrix");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}

