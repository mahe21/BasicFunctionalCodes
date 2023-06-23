using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DayConversion
    {
        public void DayConversions() 
        {
            Console.WriteLine("Enter the no of days");
            int days = int.Parse(Console.ReadLine());

            double years = days / 365;
            double weeks = (days % 365) / 7;
            double remainingDays = (days % 365) % 7;

            Console.WriteLine("years: " + years);
            Console.WriteLine("Weeks: " + weeks);
            Console.WriteLine("Reamining days: " + remainingDays);
        }
    }
}
