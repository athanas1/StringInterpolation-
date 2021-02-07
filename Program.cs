using System;

namespace StringInterpolation_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            //Created a datetime object then used custom date time formats for answers
            System.Console.WriteLine("1. {0}", today.ToString("MMMM d, yyyy"));

            System.Console.WriteLine("2. {0}", today.ToString("yyyy.MM.dd"));

            System.Console.WriteLine($"3. Day {today:dd} of {today:MMMM}, {today:yyyy}");

            System.Console.WriteLine($"4. Year: {today:yyyy}, Month: {today:MM}, Day: {today:dd}");

            System.Console.WriteLine("5. {0,10}", $"{today:dddd}");

            System.Console.WriteLine("6. {0,5}:{1,0} PM {2,15}", $"{today:hh}", $"{today:mm}", $"{today:dddd}");

            System.Console.WriteLine($"7. h:{today:hh}, m:{today:mm}, s:{today:ss}");

            System.Console.WriteLine("8. {0}", today.ToString("yyyy.MM.dd.hh.mm.ss"));

            //pi part of homework
            //Should I use double or decimal for this in the future?
            double pi = 3.14159265359;
            //using Currency format with c2
            System.Console.WriteLine("1. {0:c2}", pi);
            //using numbers format with n3
            System.Console.WriteLine("2. {0,10:n3}", pi);

        }
    }
}
