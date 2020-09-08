using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            string UserInput1 = Console.ReadLine();
            var UserInput1var = Int32.Parse(UserInput1);

            Console.WriteLine("Enter second number: ");
            string UserInput2 = Console.ReadLine();
            var UserInput2var = Int32.Parse(UserInput2);

            if (UserInput1var == UserInput2var)
            {
                Console.WriteLine($"Number 1({UserInput1var}) and Number 2({UserInput2var}) are equal.");
            }
            else
                Console.WriteLine($"Number 1({UserInput1var}) and Number 2({UserInput2var}) are not equal.");
        }

    }
}
