using System;
using System.Collections.Generic;
using System.Linq;


namespace SocialMediaLikes
{

    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            SocialMediaLikes();

        }



        private static void SocialMediaLikes()
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

                likes.Add(StringExtensions.FirstCharToUpper(nameInput));
                Console.WriteLine("You have added {0} to the list of likers! Keep Going!", StringExtensions.FirstCharToUpper(nameInput));
                Console.WriteLine("\n");
            }

            if (likes.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post! Great!", likes[0], likes[1], likes.Count - 2);

            else if (likes.Count == 2)
                Console.WriteLine("{0} and {1} like your post! What great friends.", likes[0], likes[1]);

            else if (likes.Count == 1)
                Console.WriteLine("{0} likes your post!", likes[0]);

            else
                Console.WriteLine();
        }

    }
}
