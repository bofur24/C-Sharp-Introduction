using System;

namespace Integral_Floating_Point_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Explore integer math");
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
            Console.WriteLine("");

            // order of operations

            a = 5;
            b = 4;
            c = 2;
            int d = a + b * c;
            int e = (a + b) * c;
            int f = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            int g = (a + b) / c;
            Console.WriteLine("Order of operations");
            Console.WriteLine($"{a} + {b} * {c} = {d}");
            Console.WriteLine($"({a} + {b}) * {c} = {e}");
            Console.WriteLine($"({a} + {b}) - 6 * {c} + (12 * 4) / 3 + 12 = {f}");
            Console.WriteLine($"({a} + {b}) / {c} = {g}"); // you think the answer is 4.5 but it is just 4, you have to use a different type of data point.
            Console.WriteLine("");


            // Integer precision and limits

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            e = (a + b) % c;
            int max = int.MaxValue;
            int min = int.MinValue;
            int what = max + 3;
            Console.WriteLine("Integer recision and limits");
            Console.WriteLine($"({a} + {b}) / {c} = quotient: {d}");
            Console.WriteLine($"({a} + {b}) % {c} = remainder: {e}");
            Console.WriteLine($"The range of integers is {min} to {max}");
            Console.WriteLine($"An example of overflow: {what}");
            Console.WriteLine("");

            // Working with double type

            double aa = 5;
            double bb = 4;
            double cc = 2;
            double dd = (aa + bb) / cc;
            Console.WriteLine("Working with double type");
            Console.WriteLine($"({aa} + {bb}) / {cc} = {dd}");

            aa = 19;
            bb = 23;
            cc = 8;
            dd = (aa + bb) / cc;
            Console.WriteLine($"({aa} + {bb}) / {cc} = {dd}");

            double maxx = double.MaxValue;
            double minn = double.MinValue;
            Console.WriteLine($"The range of double is {minn} to {maxx}");

            double third = 1.0 / 3.0;
            Console.WriteLine($"1.0 / 3.0 = {third}");
            Console.WriteLine("");

            //Work with fixed point types




        }
    }
}
