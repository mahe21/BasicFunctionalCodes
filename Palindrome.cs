using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Palindrome
    {
        public void PalindromeProgram()
        {
            int remainder, temp, sum = 0;
            Console.WriteLine("ENter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            temp = number;

            while (number > 0)
            {
                remainder = number % 10;
                sum = (sum * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number is: " + sum);

        }


    }
}
