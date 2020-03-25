using System;

namespace Branch_and_loop_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make decisions using the if statement

            Console.WriteLine("Make decisions using the if statement");
            int a = 5;
            int b = 6;
            if (a + b > 10)
            {
                Console.WriteLine($"{a} + {b} is > 10");
            }

            b = 3;
            if (a + b > 10)
            {
                Console.WriteLine($"{a} + {b} is > 10");
            }

            Console.WriteLine($"{a} + {b} is < 10");
            Console.WriteLine("");

            // Make if and else work together

            Console.WriteLine("Make if and else work together");
            if (a + b > 10)
            {
                Console.WriteLine($"Is {a} + {b} > 10 Answer: True");
            } else
                Console.WriteLine($"Is {a} + {b} > 10 Answer: false");

            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
            
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
            Console.WriteLine("");

            // Use loops to repeat operations

            Console.WriteLine("Use loops to repeat operations");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            Console.WriteLine("");

            counter = 1;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
            Console.WriteLine("");

            // Work with the for loop

            Console.WriteLine("Work with the for loop");

            for (counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }
            Console.WriteLine("");

            // Challenge

            Console.WriteLine("Challenge Combine branches and loops");
            Console.WriteLine("Find the sum of all integers 1 through 20 that are divisible by 3");

            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
