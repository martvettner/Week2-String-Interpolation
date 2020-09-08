using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string UserInput;

            Console.WriteLine("mis aastal sa sündisid?");
            UserInput = Console.ReadLine();
            Age = 2020 - Int32.Parse(UserInput);

            if(Age < 18)
            {
                Console.WriteLine($"sa oled liiga noor juhilubade jaoks, sa oled {Age}.");
            }
            else
            {
                Console.WriteLine($"sa oled piisavalt vana juhilubade jaoks, sa oled {Age}.");
            }
        }
    }
}