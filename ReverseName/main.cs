using System;
using System.Collections.Generic;
using System.Linq;


namespace ReverseName
{

    class Program
    {
        static void Main(string[] args)
        {

            ReverseName();
            //Second Version Commented out.
            //SecondReverseName();
        }


        // Reverses the name input to the console.
        public static void ReverseName()
        {
            List<string> fullName = new List<string>();

            Console.Write("Type your first name, then last name, and watch as the computer reverses your name!");
            Console.WriteLine();
            Console.WriteLine("Enter Your First Name:");

            while (fullName.Count < 1)
            {
                string firstNameInput = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(firstNameInput))
                    Console.Write("That's not a valid name. Please type your FIRST name:");
                else
                    fullName.Add(firstNameInput);
            }

            Console.WriteLine("Enter Your Last Name:");
            while (fullName.Count < 2)
            {

                string lastNameInput = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(lastNameInput))
                    Console.Write("That's not a valid name. Please type your LAST name:");
                else
                    fullName.Add(lastNameInput);

            }
            string reverseName = fullName[1] + " " + fullName[0] + ". What a lovely name!";
            Console.WriteLine("Your name backwards is " + reverseName);


        }
        // Second version commented out for now
        // public static void SecondReverseName()
        // {
        //     Console.Write("What's your name? ");
        //     var fullName = Console.ReadLine();
        //
        //     var nameArray = new char[fullName.Length];
        //     for (var i = fullName.Length; i > 0; i--)
        //         nameArray[fullName.Length - i] = fullName[i - 1];
        //
        //     var reversed = new string(nameArray);
        //     Console.WriteLine("Reversed name: " + reversed);
        // }

    }
}
