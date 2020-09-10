using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write your number");
            string UserInput = Console.ReadLine();
            int Num1 = Int32.Parse(UserInput);

         /*   Console.WriteLine("write your second number");
            UserInput = Console.ReadLine();
            int Num2 = Int32.Parse(UserInput);
         */

            if(Num1 > 0)
            {
                Console.WriteLine("this number positive");
            }else if  (Num1 < 0)
            {
                Console.WriteLine("this number is negative");
            }else
            {
                Console.WriteLine("the number is 0");
            }
                

        }
    }
}
