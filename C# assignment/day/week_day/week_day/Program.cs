using System;

namespace week_day
{
    class Program
    {
        enum days
        {
            workingday,holiday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter day:");
            int day = int.Parse(Console.ReadLine());
            days d;
            if (day > 0 && day <= 7)
            {
                if (day >= 1 && day <= 5)
                {
                    d = days.workingday;
                }
                else
                {
                    d = days.holiday;
                }
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("day not found");
            }
        }
    }
}
