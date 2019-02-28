using System;

namespace SpeedCamera
{

  class Program
  {

     static void Main(string[] args)
     {
        Console.Write("What is the speed limit? ");
        var speedLimit = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the speed of your car? ");
        var carSpeed = Convert.ToInt32(Console.ReadLine());

        if (carSpeed < speedLimit)
            Console.WriteLine("Ok");
        else
        {
            const int kmPerDemeritPoint = 5;
            var demeritPoints = (carSpeed - speedLimit)/kmPerDemeritPoint;

            if (demeritPoints > 12)
                Console.WriteLine("Your License Has Been Suspended");
            else
                Console.WriteLine("Demerit points: " + demeritPoints);
        }

     }

  }

}
