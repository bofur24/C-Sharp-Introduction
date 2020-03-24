using System;

namespace Declare_Use_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string aFriend = "Bill"; // aFriend is a variable assigned a value of "Bill"

            Console.WriteLine(aFriend); // prints the variable to the screen
            Console.WriteLine("Hello " + aFriend); // This is String concatenation
            Console.WriteLine($"Hello {aFriend}"); // This is string interpolation

            // Console.WriteLine() is a method that is a block of code that implements some action. It has a name so you can access it.

            string firstFriend = "Maria";
            string secondFriend = "Sage";

            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}"); // using more then one variable in a string output
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters"); // The length property returns the nubmer of characters in the string
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");

            // Trim, TrimStart(), TrimEnd() Methods

            string greeting = "     Hello World!     ";
            Console.WriteLine($"greeting has {greeting.Length} spaces!");
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart(); //removes the leading spaceing
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd(); // removes the trailing spaceing
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim(); // removes all spaceing
            Console.WriteLine($"[{trimmedGreeting}]");

            // Replace Method

            string sayHello = "Hello World";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings"); // Replace takes two parameters, the first is the string being replaced, the second is the text to replace with.
            Console.WriteLine(sayHello);

            // ToUpper(), ToLower() Methods

            Console.WriteLine(sayHello.ToUpper()); // Makes the string to all caps
            Console.WriteLine(sayHello.ToLower()); // Makes the string to all lower case

            // Contains Method

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye")); // searches the variable for the string and returns True or False.
            Console.WriteLine(songLyrics.Contains("greetings"));

            // Challenge

            Console.WriteLine(songLyrics.StartsWith("You")); 
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
            

        }
    }
}
