using System;

namespace CSpractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1, then number 2");
            
            double number1 = Convert.ToDouble(Console.ReadLine());
            
            double number2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"Multiplycation of number 1 and number 2 is {Multiply(number1, number2)}");
        }

        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
