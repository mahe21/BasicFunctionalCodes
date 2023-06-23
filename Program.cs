using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to perform DataTypeSize");
            Console.WriteLine("Enter 2 to perform DayConversion");
            Console.WriteLine("Enter 3 to perform AscII Values");
            Console.WriteLine("Enter 4 to perform Area of Circle");
            Console.WriteLine("Enter 5 to perform Arithimetic operations");
            Console.WriteLine("Enter 6 to perform EvenOrOddnumber");
            Console.WriteLine("Enter 7 to perform Largest among two numbers");
            Console.WriteLine("Enter 8 to perform Palindrome");


            int options =  Convert.ToInt32(Console.ReadLine());
            

            switch (options)
            {
                case 1:                    
                    DataTypesSize dataTypesSize = new DataTypesSize();
                    dataTypesSize.Size();
                    break;
                case 2:                   
                    DayConversion dayConversion = new DayConversion();
                    dayConversion.DayConversions();
                    break;
                case 3:                    
                    AsciiValues asciiValues = new AsciiValues();
                    asciiValues.AscIIValues();
                    break;
                case 4:                   
                    AreaOfCircle areaOfCircle = new AreaOfCircle();
                    areaOfCircle.CircleArea();
                    break;
                case 5:                   
                    ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
                    arithmeticOperations.ArithmeticOperation();
                    break;
                case 6: 
                    Even_or_odd even_Or_Odd = new Even_or_odd();
                    even_Or_Odd.EvenOrOdd();
                    break;
                case 7:
                    Largest_of_Two_Numbers largest_Of_Two_Numbers = new Largest_of_Two_Numbers();
                    largest_Of_Two_Numbers.Largest_Number();
                    break;
                case 8:
                    Palindrome palindrome = new Palindrome();
                    palindrome.PalindromeProgram(); 
                    break;
                default:
                    Console.WriteLine("Enter numbers between 1 to 8");
                    break;
                   
            }
            

            

            

            

            
        }
    }
}