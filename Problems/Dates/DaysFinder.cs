using System;

namespace ProblemSolving.Problems.Dates
{
    /// <summary>
    /// This class is responsible for performing operations on Date like
    /// Print no. of days between two dates using DateTime inbuilt class
    /// Print no. of days between two dates with out using any inbuilt functions
    /// </summary>
    public class DaysFinder
    {

        public int GetNumberOfDaysUsingInbuiltAPIs(DateTime startDate, DateTime endDate)
        {
            return endDate.Subtract(startDate).Days;
        }


        public int GetNumberOfDays(string startDate, string endDate)
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
            return yearDays + monthsDays + days;
        }

        private int GetDay(string date)
        {
            string[] arr = date.Split('/');
            return Convert.ToInt32(arr[1]);
        }

        private int GetMonth(string date)
        {
            string[] arr = date.Split('/');
            return Convert.ToInt32(arr[0]);
        }

        private int Getyear(string date)
        {
            string[] arr = date.Split('/');
            string year = arr[2].Substring(0, arr[2].IndexOf(' '));
            return Convert.ToInt32(year);
        }

        private int DaysInMonth(int month, int year)
        {
            int[] months = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30,
                31};
            if (IsLeapYear(year) && month == 2)
                return 29;
            return months[month - 1];
        }

        private int GetNumberofDaysinMonthDifference(int startMonth, int endMonth, int startyear)
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

        private int GetNumberOfDaysInDaysDifference(int startDay, int endDay)
        {
            return endDay - startDay;
        }

        private int GetNumberOfDaysInYearDifference(int startYear, int endYear)
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

        private bool IsLeapYear(int year)
        {
            if (year % 4 == 0 || year % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
