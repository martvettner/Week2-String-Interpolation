using System;

namespace Week2IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string UserInput;

            Console.WriteLine("how old are you?");
            UserInput = Console.ReadLine();
            age = Int32.Parse(UserInput);

            if (age < 18)

            {
                Console.WriteLine($"you are {age}, you are too young.");
            }

           else if (age > 18)

            {
                Console.WriteLine($"you are old enough for a this site, you are {age}");
            }



        }
    }
}

