using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human myPerson = new Human("Billy");
            Human myPerson2 = new Human("Sally", 4, 4, 2, 85);
            myPerson.Attack(myPerson2);
        }

    }

}
