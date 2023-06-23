using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Even_or_odd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("ENter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine(number + ": is even Number");
            }
            else
            {
                Console.WriteLine(number + ": is odd number");
            }
        }
    }
}
