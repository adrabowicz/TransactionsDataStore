using System;

namespace CommonData
{
    public static class DataUtility
    {
        public static string FormatCurrentDateTime()
        {
            return FormatDateTime(DateTime.Now);
        }

        public static string FormatDateTime(DateTime dateTime)
        {
            var dateTimeString = dateTime.ToString("yyyy-MM-dd_hh:mm:ss+");
            dateTimeString = dateTimeString.Replace('_', 'T').Replace("+", ".000Z");
            return dateTimeString;
        }

        public static DateTime GetRandomDateTime(Random random, DateTime minDate, DateTime maxDate)
        {
            var timeSpan = maxDate - minDate;
            var newSpan = new TimeSpan(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);
            var newDate = minDate + newSpan;
            return newDate;
        }
    }
}
