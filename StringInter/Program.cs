using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("mis su nimi on?");
            // Console.ReadLine();
            string FirstName;
            string LastName;
            Console.WriteLine("mis su nimi on?");
            FirstName = Console.ReadLine();

            Console.WriteLine("mis su perekonna nimi on?");
            LastName = Console.ReadLine();
           
            //Console.WriteLine("tere " + FirstName + " " + LastName);


            Console.WriteLine($"hello {FirstName} {LastName}");






        }
    }
}
