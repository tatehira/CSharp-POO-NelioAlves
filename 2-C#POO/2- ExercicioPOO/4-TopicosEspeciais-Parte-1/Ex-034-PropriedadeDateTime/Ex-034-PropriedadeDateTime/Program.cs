﻿using System;

namespace Ex_034_PropriedadeDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                • Date (DateTime)
                • Day (int)
                • DayOfWeek (DayOfWeek)
                • DayOfYear (int)
                • Hour (int)
                • Kind (DateTimeKind)
                • Millisecond (int)
                • Minute (int)
                • Month (int)
                • Second (int)
                • Ticks (long)
                • TimeOfDay (T
                • Year (int)
             */

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            #region Formatacao

            DateTime dt = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = dt.ToLongDateString();
            string s2 = dt.ToLongTimeString();
            string s3 = dt.ToShortDateString();
            string s4 = dt.ToShortTimeString();
            string s5 = dt.ToString();
            string s6 = dt.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = dt.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            #endregion

            #region Operacoes com datetime

            DateTime x = ...
            DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);

            #endregion

        }
    }
}