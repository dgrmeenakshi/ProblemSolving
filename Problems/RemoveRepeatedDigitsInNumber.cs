using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProblemSolving.Problems
{
    public class RemoveRepeatedDigitsInNumber
    {
       public int RemoveRecurdigits(int n)
        {
            
           int prev_digit = 0;
            int pow = 10;
            int res = 0;
             while (n > 0)
            {
                int curr_digit = n % 10;

                if (curr_digit != prev_digit)
                {
                    
                     res = res+ curr_digit * pow;
                     prev_digit = curr_digit;
                     pow = pow* 10;
                }
              n = n / 10;
            }

            return res;
        }

        public string ConvertDigitToChar(int digit)
        {
            string converter = string.Empty;
            if (digit == 1)
                converter = "A";
            else if (digit == 2)
                converter = "B";
          else if (digit == 3)
                converter = "C";
            else if (digit == 4)
                converter = "D";
            else if (digit == 5)
                converter = "E";
            else if (digit == 6)
                converter = "F";

            return converter;
        }

        public string ConverttoStringAndRmoveDuplicates(int num)
        {
            int digits = RemoveRecurdigits(num);
            return ConvertDigitToChar(digits);
        }
    }
}