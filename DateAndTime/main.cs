using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Just getting the current time.
            // This section demonstrates how to get the current time
            // and different ways to display / format that time and date.
            var dateTime = new DateTime(2015,1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("The time is: " + now.Hour + ":" + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine();
            Console.WriteLine("Today is: " + now.ToShortDateString() + " and the Time is: " + now.ToShortTimeString());
            Console.WriteLine();
            Console.WriteLine("Today is: " + now.ToString("MM-dd-yyyy hh:mm"));

            Console.WriteLine();
            // This section goes over timespan
            // That is, the length of time, between two times.
            var timeSpan = new TimeSpan(1, 2, 3); // overload (hours, minutes, seconds)

            // or use static methods with timespan object with overloads.
            var timeSpan1 = TimeSpan.FromHours(1);

            //DateTime has a static property called Now which returns current Date/Time
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // TimeSpan Properties: (Days, hours, minutes, ticks, ms, TotalDays, TotalHours, etc.)
            Console.WriteLine();

            // returns only our mins from the timespan above:
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            // returns total minutes of the hours, mins, and secs, we set in our var above:
            Console.WriteLine("TotalMinutes " + timeSpan.TotalMinutes);

            // Add (timespan is immutable like DateTime

            // 1 hour, 10 mins, 3 seconds
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            // 1 hour, 3 seconds:
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // Conversion to and from strings:
            // ToString:
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parse:
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));



        }
    }
}
