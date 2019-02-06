using System;

namespace Prototype
{
    internal class Program
    {
        private static void Main()
        {
            var roster = new Roster();
            var halfDayVacation = roster.CloneVacationObject("half_day");
            Console.WriteLine(halfDayVacation.ObjectName);
            Console.WriteLine(halfDayVacation.Duration);
            Console.WriteLine(halfDayVacation.IsPaid);
            Console.ReadLine();
        }
    }
}
