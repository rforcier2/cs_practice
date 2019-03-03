using System;
using ObjectDemo.Math;

namespace ObjectDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            IntroProgram();
            AddingProgram();
        }

        public static void IntroProgram()
        {
            Person newUser = new Person();

            Console.WriteLine("Type your First Name: ");
            newUser.FirstName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Type Your Last Name:");
            newUser.LastName = Console.ReadLine();
            newUser.Introduce();
            Console.WriteLine();
        }

        public static void AddingProgram()
        {

            Console.WriteLine("Type 2 numbers to add together!");
            var calc = new Adder();
            Console.WriteLine("First Number to Add, then press ENTER:");
            var firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Number is {0}! Got it.\n", firstNum);

            Console.WriteLine("Now type the second number to Add, then press ENTER:");
            var secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number is {0}! Let's add them!\n", secondNum);

            var result = calc.Add(firstNum, secondNum);
            Console.WriteLine("The result of {0} + {1} is: {2}! Nice work!", firstNum, secondNum, result);
        }
    }
}
