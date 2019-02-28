namespace MaxNumberOutOfMany
{

    class Program
    {

      static void Main(string[] args)
      {

        Console.Write("Enter comma separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max
            var max = Convert.ToInt32(numbers[0]);

            foreach (var index in numbers)
            {
                var number = Convert.ToInt32(index);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);

      }

    }

}
