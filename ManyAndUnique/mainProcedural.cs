using System;
using System.Collections.Generic;
using System.Linq;


namespace ManyAndUnique
{

    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Sorted unique numbers from your list:");
            foreach (var number in GetUniqueNumbers(allNumbers))
            {
                Console.Write(number + ", ");
            }

        }

        // Displays only Unique Numbers, but this time the user can enter as many as they like.
        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            List<int> uniqueNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }
            uniqueNumbers.Sort();
            return uniqueNumbers;

        }

    }
}
