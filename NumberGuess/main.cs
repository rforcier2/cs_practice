using System;

namespace NumberGuesses
{

  class Program
  {

      static void Main(string[] args)
      {
            var number = new Random().Next(1, 10);

            Console.WriteLine("Secret is " + number);
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You win!");
                    return;
                }
            }

            Console.WriteLine("You lost!");
      }

  }

}
