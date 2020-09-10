using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what's your favourite animal?");
            string userInput;
            userInput = Console.ReadLine();
            if (userInput == "dog")
            {
                Console.WriteLine("you are a partygoer");
            } else if (userInput == "cat")
            {
                Console.WriteLine("you are a homebird");
            }else
            {
                Console.WriteLine($"you are a {userInput} friend");
            }

           
        }
    }
}
