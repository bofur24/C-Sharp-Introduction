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
        }
    }
}
