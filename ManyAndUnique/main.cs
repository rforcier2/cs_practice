using System;
using System.Collections.Generic;
using System.Linq;


namespace ManyAndUnique
{

    class Program
    {
        static void Main(string[] args)
        {
            DisplayUnique();
        }

        // Displays only Unique Numbers, but this time the user can enter as many as they like.
        public static void DisplayUnique()
        {
            Console.WriteLine("Enter as many numbers as you like! Type QUIT at any point to stop and see the unique numbers you entered.");
            List<int> allNumbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or QUIT to exit): ");
                var userInput = Console.ReadLine();

                if (userInput.ToUpper() == "QUIT")
                    break;
                allNumbers.Add(Convert.ToInt32(userInput));
            }

            List<int> uniqueNumbers = new List<int>();

            foreach (int number in allNumbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }

            Console.WriteLine("Unique Numbers from your list:");
            uniqueNumbers.Sort();
            foreach (var number in uniqueNumbers)
            {
                Console.Write(number + ", ");
            }

        }

    }
}
