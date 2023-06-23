using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArithmeticOperations
    {

        public void ArithmeticOperation()
        {
            Console.WriteLine("enter first number: ");
            int num_One = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int num_Two = int.Parse(Console.ReadLine());

            int sum = num_One + num_Two;
            int difference = num_One - num_Two;
            int product = num_One * num_Two;
            double quotient = num_One / num_Two;

            Console.WriteLine("Sum is: " + sum);
            Console.WriteLine("Difference is" +  difference);
            Console.WriteLine("Product is: " +  product);
            Console.WriteLine("Quotient is: " +  quotient);
        }

    }
}
