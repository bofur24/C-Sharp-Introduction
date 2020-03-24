using System;

namespace Integral_Floating_Point_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18; //int type represents an integer, a positive or negatice whole number
            int b = 6;

            int c = a + b; // + symbol for addition
            Console.WriteLine($"{a} + {b} = {c} Addition");

            c = a - b; // - symbol for subtraction
            Console.WriteLine($"{a} - {b} = {c} Subtraction");

            c = a * b; // * symbol for multiplication
            Console.WriteLine($"{a} * {b} = {c} Multiplication");

            c = a / b; // / symbol for division
            Console.WriteLine($"{a} / {b} = {c} Division");
        }
    }
}
