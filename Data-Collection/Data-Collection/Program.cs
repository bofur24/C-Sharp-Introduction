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
        }
    }
}
