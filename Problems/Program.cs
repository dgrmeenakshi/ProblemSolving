using System;

namespace ConsoleApplication1
{
    /// <summary>
    /// This class is responsible for performing operations on Date like
    /// 1. Print the day of week by adding or subtracting the days
    /// 2. Print no. of days between two dates using DateTime inbuilt class
    /// 3. Print no. of days between two dates with out using any inbuilt functions
    /// </summary>
    public class DatesDifference
    {
        static void Main()
        {
          
            DateTime startDate = new DateTime(2000, 01, 03);
            DateTime endDate = new DateTime(2010, 08, 04);
            DisplayDayOfTheWeekByAddingOrSubtractingDays(startDate);
            DisplayDiffernceBetweenTwoDatesUsingInbuiltFunctions(startDate, endDate);
            DisplayDiffernceBetweenTwoDatesWithoutInbuiltFunctions(startDate.ToString(), endDate.ToString());

            Console.ReadLine();
        }

        public static void DisplayDayOfTheWeekByAddingOrSubtractingDays(DateTime date)
        {
            Console.WriteLine(" Present Day of the week : " + date.DayOfWeek);
            Console.Write("Add days : ");
            int inputDays = int.Parse(Console.ReadLine());
            Console.WriteLine("After adding {0} days, the day of the week is : {1}", inputDays, date.AddDays(inputDays).DayOfWeek);

            Console.Write("Subtract days : ");
            int inputDay = int.Parse(Console.ReadLine());
            Console.WriteLine("After Subtracting {0} days, the day of the week is : {1}", inputDay, date.AddDays(-inputDay).DayOfWeek);
        }

        public static void DisplayDiffernceBetweenTwoDatesUsingInbuiltFunctions(DateTime startDate, DateTime endDate)
        {
            Console.WriteLine("The number of days between two dates using inBuilt Function {0} , {1} : {2}", startDate, endDate, endDate.Subtract(startDate).Days);

        }


        public static void DisplayDiffernceBetweenTwoDatesWithoutInbuiltFunctions(string startDate, string endDate)
        {
            int startYear = Getyear(startDate);
            int endYear = Getyear(endDate);
            int yearDays = GetNumberOfDaysInYearDifference(startYear, endYear);


            int startMonth = GetMonth(startDate);
            int endMonth = GetMonth(endDate);
            int monthsDays = GetNumberofDaysinMonthDifference(startMonth, endMonth, startYear);


            int startDay = GetDay(startDate);
            int endDay = GetDay(endDate);
            int days = GetNumberOfDaysInDaysDifference(startDay, endDay);
            Console.WriteLine("The number of days are {0} + {1} + {2} is {3}", yearDays, monthsDays , days, yearDays+monthsDays+days);


        }

        private static int GetDay(string date)
        {
            string[] arr = date.Split('/');
            return Convert.ToInt32(arr[1]);
        }

        private static int GetMonth(string date)
        {
            string[] arr = date.Split('/');
            return Convert.ToInt32(arr[0]);
        }
        private static int Getyear(string date)
        {
            string[] arr = date.Split('/');
            string year = arr[2].Substring(0, arr[2].IndexOf(' '));
            return Convert.ToInt32(year);
        }
        private static int DaysInMonth(int month, int year)
        {
            int[] months = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30,
                31};
            if (IsLeapYear(year) && month == 2)
                return 29;
            return months[month - 1];
        }

        private static int GetNumberofDaysinMonthDifference(int startMonth, int endMonth, int startyear)
        {
           int diff = endMonth - startMonth;
           int days = 0;
           while (diff > 0)
           {
               days = days + DaysInMonth(startMonth, startyear);
               startMonth++;
               startyear++;
               diff--;
           }

           return days;
           }

        private static int GetNumberOfDaysInDaysDifference(int startDay, int endDay)
        {
            return endDay - startDay;
        }

        private static int GetNumberOfDaysInYearDifference(int startYear, int endYear)
        {
            int days = 0;
            int diff = endYear - startYear;
            while (diff == 0)
            {
            }
            while (diff > 0)
            {
                if (IsLeapYear(startYear))
                {
                    days = days + 366;
                }
                else
                {
                    days = days + 365;
                }
                startYear++;
                diff--;
            }

            return days;
        }

        private static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 || year % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
