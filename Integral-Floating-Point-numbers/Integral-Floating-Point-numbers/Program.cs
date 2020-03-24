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

            // order of operations

            a = 5;
            b = 4;
            c = 2;
            int d = a + b * c;
            int e = (a + b) * c;
            int f = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            int g = (a + b) / c;
            Console.WriteLine($"{a} + {b} * {c} = {d}");
            Console.WriteLine($"({a} + {b}) * {c} = {e}");
            Console.WriteLine($"({a} + {b}) - 6 * {c} + (12 * 4) / 3 + 12 = {f}");
            Console.WriteLine($"({a} + {b}) / {c} = {g}"); // you think the answer is 4.5 but it is just 4, you have to use a different type of data point.


        }
    }
}
