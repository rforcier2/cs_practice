using System;
using System.IO;

namespace StringUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\temp\test.txt";
            Console.WriteLine("Put the Text you wish to Summarize in the test.txt folder located at - {0}", path);

            if (File.Exists(path))
            {
                // Summary:
                var sentence = File.ReadAllText(path);
                var summary = StringUtility.SummarizeText(sentence, 40);

                Console.WriteLine("SUMMARY: " + summary);


                // Find word:
                var keyword = "test";
                var findWord = StringUtility.FindKeyword(sentence, keyword);

                Console.WriteLine(findWord);

                //Reverse Text:
                var stringToReverse = "This is going to be backwards";
                Console.WriteLine(StringUtility.ReverseText(stringToReverse));


            }
            else
                Console.WriteLine("No file can be read from that path. Try again.");
        }



    }
}
