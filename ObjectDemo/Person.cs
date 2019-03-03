using System;

namespace ObjectDemo
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Nice to see you again {0} {1}!", FirstName, LastName);
        }
    }
}
