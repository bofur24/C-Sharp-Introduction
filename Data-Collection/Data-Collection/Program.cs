using System;
using System.Collections.Generic;

namespace Data_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Lists

            Console.WriteLine("Create Lists");
            var names = new List<string> { "Keith", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("");

            // Modify List Contents

            Console.WriteLine("Modify List Contents");
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("");
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine("");

            Console.WriteLine($"The list has {names.Count} people in it.");
            Console.WriteLine("");

            // Search and sort lists

            Console.WriteLine("Search and sort lists");

            var index = names.IndexOf("Felipe");
            if (index != -1)
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
            Console.WriteLine("");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("");

            // Lists of other types

            var fibonacciNumbers = new List<int> { 1, 1 };

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

            // Challenge

            var fibonacciChallenge = new List<int> { 1, 1 };

            while (fibonacciChallenge.Count < 20)
            {
                var previous3 = fibonacciChallenge[fibonacciChallenge.Count - 1];
                var previous4 = fibonacciChallenge[fibonacciChallenge.Count - 2];

                fibonacciChallenge.Add(previous3 + previous4);
            }

            foreach (var test in fibonacciChallenge)
                Console.WriteLine(test);
        }
    }
}
