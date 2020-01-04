using System;
using NUnit.Framework;

namespace ProblemSolving.Problems.Dates
{
    [TestFixture]
   public class DaysFinderTests
   {
       private DaysFinder daysFinder = new DaysFinder();

        [Test]
        public void EnterTwoValidDates_ShouldDisplayNumberOfDaysBetweenDates()
        {
            DateTime startDate = new DateTime(2000, 01, 03);
            DateTime endDate = new DateTime(2010, 08, 04);
            int result = daysFinder.GetNumberOfDays(startDate, endDate);
            Assert.AreEqual(3866,result,"Number of days between two dates are incorrect ");
        }

        [Test]

        public void EnterTwoValidDates_ShouldDisplayNumberOfDaysBetweenDatesUsingInbuitltAPI()
        {
            DateTime startDate = new DateTime(2000, 01, 03);
            DateTime endDate = new DateTime(2010, 08, 04);
            int result = daysFinder.GetNumberOfDaysUsingInbuiltAPIs(startDate, endDate);
            Assert.AreEqual(3866, result, "Number of days between two dates are incorrect ");
        }


   }
}
