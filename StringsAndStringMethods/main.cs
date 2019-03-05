using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
        // Summary Of Strings and Methods:
            // In C# String keyword maps to the String Class in .NET Class
            // Strings are immutable (once created, cannot change them)

            // Formatting:
            // toLower(), toUpper(), Trim();

            // Searching:
            // IndexOf(), or LastIndexOf();
            // both methods have overload and accept either character or a string.
            // return index, or last index of given char or string

            // Substrings:
            // Substring(startIndex)
            // Subtring(startIndex, length)
            // startIndex overload retrieves all chars from that point until end of string.
            // length limits number of chars to retrieve.

            // Replacing:
            // Replace('char/string', 'replacement')
            // first overload determines which char to replace, second overload what to replace it with.

            // Null Checking:
            // String.IsNullOrEmptry(str)
            // String.IsNullOrWhiteSpace(str)
            // These methods are simple way to compare string to null or empty string / whitepsace

            // Splitting:
            // str.Split('char to split string')
            // this splits the string with chosen char. (ie. str.Split(' ') splits string with empty char)

            // Converting Strings to Numbers:
            // string s = "1234";
            // int i = int.Parse(s);
            // int j = Convert.ToInt32(s);
            // string representation of number. exmaple, when user types number into text box,
            // it will be a string, so we need to convert that entry into a number.
            // Convert.ToInt32() if string is null or empty, Convert will return default value (0)
            // int.Parse() will throw an exception.

            // Converting Numbers to String:
            // int i = 1234;
            // string s = i.ToString();     = "1234"
            // string t = i.ToString("C");  = "$1,234.00"
            // string t = i.ToString("C0"); = "$1,234"
            // without arguement - just converts integer to a number
            // or we can format the number using a format string
            // C is a format string for currency. By default has 2 decimal point numbers
            // C0 is to get no decmials and C1 is for one decimal point.
            // Some Common Format Strings:
            // c or C : Currency    = 123456(C)       => $123,456
            // d or D : Decimal     = 1234(D6)        => 001234
            // e or E : Exponential = 1052.0329112756 => 1.052033E+003
            // f or F : Fixed Point = 1234.567(F1)    => 1234.5
            // x or X : Hexadecimal = 255(X)          => FF
        // End Summary

       // Demonstration of some string methods:

            // .Trim() method to clear spaces around strings:
            var fullName = "John Smith ";
            Console.WriteLine("Trim(): '{0}' \n", fullName.Trim());

            // Convert String ToUpper()
            Console.WriteLine("ToUpper(): '{0}' \n", fullName.ToUpper());

            // Separate string into first & last name
            
            // First Solution:
            Console.WriteLine("First Solution for splitting name using IndexOf method:");
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            // note, we want the last name which is from index+1 to the end of the string,
            // so no need to specify length overload
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine();

            // Second Solution to get first and last name using .Split() method:
            Console.WriteLine("Second Solution using .Split() method:");

            // return type of Split() method is a string[] array.
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: {0}", names[0]);
            Console.WriteLine("LastName: {0}", names[1]);
            Console.WriteLine();

            // Now we will look at .Replace() method:
            Console.WriteLine("Now we will look at .Replace() method:");
            Console.WriteLine("Original Name: {0}", fullName);
            Console.WriteLine("Replace John to Johnathan: {0}",fullName.Replace("John", "Johnathan"));
            Console.WriteLine();

            // Using StringIsNullOrEmpty() or StringIsNullOrWhiteSpace() methods:
            if (String.IsNullOrEmpty(null) || String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid! StringIsNullOrEmpty() Example!");

            // Used to have to use .Trim() First to ensure users aren't just simply adding a " " space and then
            // check using is NullOrEmpty() method, however, you can use IsNullOrWhiteSpace() method now
            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid! Only whitepace or null present");
            Console.WriteLine();

            // Receive Inputs from user as string and need to convert to number.
            // Note: can use Convert.ToByte() instead of .ToInt32() because no one will be older than 250 years old:
            var userInput = "25";
            var userAge = Convert.ToByte(userInput);
            Console.WriteLine("Converting 'string' input into a number. Age example:");
            Console.WriteLine("User Age: {0}", userAge);
            Console.WriteLine();

            // Now to convert a number to a string using .ToString() method.
            // Since this example is a price, we want to use the "C" format string
            Console.WriteLine("Now we convert number to a string:");
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine();


        }
    }
}
