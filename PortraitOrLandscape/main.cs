using System;
using System.Threading;

namespace PortraitOrLandscape
{

    class Program
    {

        static void Main(string[] args)
        {
            string textResult = "Loading  ";
            string loadingDots = "...............";

            Console.WriteLine(
@"            *******************************************
            * Enter the width and height of a picture *
            * and I will determine                    *
            * if it is landscape or portrait!         *
            *******************************************");
            Console.WriteLine(
            @"                                         ");

            Console.WriteLine(
                @"Enter the height now:"
            );
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(
            @"                                         ");

            Console.WriteLine("Now enter the width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(
            @"                                         ");

            for(int i = 0; i < textResult.Length; i++)
            {

                Console.Write( textResult[i] );
                Thread.Sleep(100);
            }


            for(int j = 0; j < loadingDots.Length; j++)
            {
                Thread.Sleep(50);

                Console.Write("\b\\");
                Thread.Sleep(50);
                Console.Write("\b|");
                Thread.Sleep(50);
                Console.Write("\b/");
                Thread.Sleep(50);
                Console.Write("\b-");
            }


            if (height <= 0 || width <=0)
                Console.WriteLine("\n\nThis picture cannot exist! Try again");
            if (height > 0 && width > 0)
            {
                if (height > width)
                {
                    Console.WriteLine("\n\nThis picture is portrait!");
                    Console.Write(@" _____
|     |
|     |
|     |
|_____|");
                    Console.WriteLine();
                }
                else if (height < width)
                {
                   Console.WriteLine("\n\nThis picture is landscape!");
                    Console.Write(@" __________
|          |
|          |
|__________|");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\n\nThis picture is a perfect square! Buy the right frame :)");
                }
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
