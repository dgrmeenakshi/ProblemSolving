using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems
{
    public class Matrix
    {
        public int[,] EnterMatrixInts(int row, int col, int[,] arrInts)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arrInts[i,j]= int.Parse(Console.ReadLine()+ "  ");
                 
                }

                Console.WriteLine(" ");
            }

            return arrInts;
        }

        public void PrintMatrixDiagonaly(int row , int col, int[,] arrInts)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(arrInts[i,j] + " ");
                    }
                }
            }
        }

        public void PrintMatrixInOneLine()
        {

        }

        public void PrintSpiralMatrix()
        {

        }
    }
}
