using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {


            var likes = new List<string>();
            Console.Write("Type Names of those who liked your post below!");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Type a name to add (or ENTER to quit): ");
                var nameInput = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(nameInput))
                    break;

                likes.Add(nameInput);
                Console.WriteLine("You have added {0} to the list of likers! Keep Going!", nameInput);
                Console.WriteLine("\n");
            }

            if (likes.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post! Great!", likes[0], likes[1], likes.Count - 2);
            else if (likes.Count == 2)
                Console.WriteLine("{0} and {1} like your post", likes[0], likes[1]);
            else if (likes.Count == 1)
                Console.WriteLine("{0} likes your post.", likes[0]);
            else
                Console.WriteLine();

        }
    }
}
