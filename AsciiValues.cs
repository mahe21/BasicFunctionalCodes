using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AsciiValues
    {
        public void AscIIValues()
        {
            char character;
            Console.WriteLine("Enter a character: ");
            character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nASCII Value of " + character + " " + Convert.ToInt32(character));
            Console.ReadKey();
        }
    }
}
