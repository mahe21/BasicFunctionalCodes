using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Largest_of_Two_Numbers
    {
        public void Largest_Number()
        {
            Console.WriteLine("Enter the first number");
            int number_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int number_Two = Convert.ToInt32(Console.ReadLine());

            if(number_One > number_Two)
            {
                Console.WriteLine(number_One + ": is larger than " + number_Two);
            }
            else if (number_Two == number_One)
            {
                Console.WriteLine(number_One + ": is equal to " + number_Two);
            }
            else
            {
                Console.WriteLine(number_Two + ": is larger than " + number_One);
            }        
        }
    }
}
