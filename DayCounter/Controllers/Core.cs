using System;
using DayCounter.Interfaces;

namespace DayCounter.Controllers
{
    class Core : ICore
    {
        private bool useToday;
        private DateTime startTime, endTime;

        public Core(bool UseToday, DateTime StartTime, DateTime EndTime)
        {
            useToday = UseToday;
            startTime = StartTime;
            endTime = EndTime;
        }

        public string GetResult()
        {
            return (getResult(useToday, startTime, endTime));
        }

        private string getResult(bool isToday, DateTime start, DateTime end)
        {
            DateTime t1 = (isToday) ? DateTime.Now : start;
            DateTime t2 = end;
            TimeSpan t = t2 - t1;
            int dd = t.Days;
            int hh = t.Hours % 24;
            int mm = t.Minutes % 60;
            int ss = t.Seconds % 60;
            string ans = (isToday) ?
                string.Format("{0} days {1} hours {2} minutes {3} seconds to go! ", dd, hh, mm, ss) :
                string.Format("{0} days to go! ", dd);
            return (ans);
        }

    }
}
