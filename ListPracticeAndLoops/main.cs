using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // Initiate a new List of a specific size and type:
        var myList = new List<int>() {1, 2, 3, 4};

       // Add 1 to the list of numbers:
        myList.Add(1);

        // Add an array of numbers to our list:
        myList.AddRange(new int[4] { 5, 6, 2, 7});

        // Display all numbers in our list:
        Console.WriteLine("My List:");
        foreach(var number in myList)
        {
            Console.WriteLine(number);
        }

        // Find the first and last index of the number 1 in our list:
        Console.WriteLine();
        Console.WriteLine("Index of 1: " + myList.IndexOf(1));
        Console.WriteLine("Last Index of 1: " + myList.LastIndexOf(1));
        Console.WriteLine();

        // Remove the first instance of the number 1
        myList.Remove(1);
        Console.WriteLine("My List After Removing 1: ");
        foreach(var number in myList)
        {
            Console.WriteLine(number);
        }

        // Remove all instances of 2 in our list
        // Can't modify with foreach loop, should be for loop

        for(var i = 0; i < myList.Count; i++)
        {
            if(myList[i] == 2)
            {
              myList.Remove(myList[i]);
            }
        }

        Console.WriteLine();
        Console.WriteLine("My List After Removing All 2s: ");
        foreach(var number in myList)
        {
            Console.WriteLine(number);
        }

        // Clear the List
        myList.Clear();
        Console.WriteLine();

        Console.WriteLine("myList count After Clearing: ");
        Console.WriteLine("Count: " + myList.Count);

    }
}
