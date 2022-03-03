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
    }
}
