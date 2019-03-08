using System;
using System.Collections.Generic;


namespace SummarizeText
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            if (text.Length < maxLength)
                return text;

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";

         }

        public static string FindKeyword(string text = "null", string keyword = "null")
        {

            var found = text.ToLower().IndexOf(keyword);

            if (found > -1)
                return "Keyword '" + keyword + "' FOUND at index => " + found;

            else
                return "'" + keyword + "' => NOT FOUND in text";
        }

        public static string ReverseText(string text = "null")
        {

            var textArray = new char[text.Length];

            for (var i = text.Length; i > 0; i--)
                textArray[text.Length - i] = text[i - 1];

            return new string(textArray);
        }


    }
}
