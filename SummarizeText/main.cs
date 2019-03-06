using System;

namespace SummarizeText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really long piece of text.";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }

    }
}
