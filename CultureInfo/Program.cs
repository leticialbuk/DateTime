using System;
using System.Globalization;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var utcDate = DateTime.UtcNow;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);

            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            //var atual = CultureInfo.CurrentCulture;
            //Console.WriteLine(DateTime.Now.ToString("D", atual));

        }

    }
}