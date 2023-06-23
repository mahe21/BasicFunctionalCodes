using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DataTypesSize
    {
        public void Size()
        {
            Console.WriteLine("size of int: " + sizeof(int)  + " Bytes");
            Console.WriteLine("size of float: " + sizeof(float) + " Bytes");
            Console.WriteLine("size of double: " + sizeof(double) + " Bytes");
            Console.WriteLine("size of bool: " + sizeof(bool) + " Bytes");
            Console.WriteLine("size of char: " + sizeof(char) + " Bytes");
            Console.WriteLine("size of short: " + sizeof(short) + " Bytes");
            Console.WriteLine("size of long: " + sizeof(long) + " Bytes");          

        }
    }
}
