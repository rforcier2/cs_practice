using System;
using System.Collections.Generic;
using System.Linq;


namespace ThreeSmallest
{

    class Program
    {
        static void Main(string[] args)
        {

            ThreeSmallest();

        }


        // Program that asks the user to supply a list of comma
        // separated numbers(e.g 5, 1, 9, 2, 10).
        // If the list is empty or includes less than 5 numbers, displays "Invalid List"
        // Ask the user to re-try;
        // Otherwise, if correct, this program displays the 3 smallest numbers in the list.
        public static void ThreeSmallest()
        {
            Console.WriteLine("Please provide a list of comma separated numbers with more than five numbers.");
            Console.WriteLine("Once complete, I will display the three smallest numbers in your list.");
            Console.WriteLine("Please enter at least five numbers in this format: 1,2,3,4,5");

            string[] entries;

            while (true)
            {
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    entries = input.Split(",");
                    if (entries.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid List! Please make a list like this example: 1,2,3,4,5");
            }

            List<int> allNumbers = new List<int>();
            foreach(var number in entries)
            {
                allNumbers.Add(Convert.ToInt32(number));
            }

            List<int> threeSmallest = new List<int>();

            while(threeSmallest.Count < 3)
            {
                var minNumber = allNumbers[0];
                foreach(var number in allNumbers)
                {
                    if (number < minNumber)
                        minNumber = number;
                }
                threeSmallest.Add(minNumber);
                allNumbers.Remove(minNumber);
            }

            Console.WriteLine("You're three smallest entries were:");
            foreach(var number in threeSmallest)
            {
                Console.WriteLine(number);
            }


        }

    }
}
