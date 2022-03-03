using System;
using System.Collections.Generic;
using System.Text;

namespace csharpFundamentals.Class.Dates
{
    class DatesTime
    {
        public void DateTimes()
        {
            var dateTime = new DateTime(2015,1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine("{0}, {1}, {2}", dateTime, now,today);
            Console.WriteLine("Hour "+ now.Hour);
            Console.WriteLine("Minute "+now.Minute);
            Console.WriteLine("--------------------------------------------------------");
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));

        }

        public void TimeSpans()
        {
            //Creating
            var timeSpan = new TimeSpan(1,2,3);

            var timeSpan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration "+duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("toString: "+ timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: "+ TimeSpan.Parse("01:02:03"));
        }
    }
}
