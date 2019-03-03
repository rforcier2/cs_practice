using System;
using System.Collections.Generic;
using System.Linq;


namespace FiveUnique
{

    class Program
    {
        static void Main(string[] args)
        {

            FiveUnique();

        }


        // Asks user to input 5 unique numbers, 1 at a time.
        // if numbers aren't unique, ask the user to try again.
        // sort the numbers and display them in the console.
        public static void FiveUnique()
        {
            List<int> fiveNums = new List<int>();
            Console.WriteLine("Please Enter 5 Unique Numbers:");
            while (fiveNums.Count < 5)
            {
                Console.Write("Enter a unique number:");
                var numInput = Convert.ToInt32(Console.ReadLine());

                if (fiveNums.Contains(numInput))
                {
                    Console.WriteLine("You've already entered that number. Please enter a unique number:");
                    continue;
                }

                fiveNums.Add(numInput);
            }

            fiveNums.Sort();
            Console.WriteLine("Your Numbers sorted are:");
            foreach (int number in fiveNums)
            {
                Console.WriteLine(number);
            }
        }

    }
}
