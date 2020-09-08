using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string Lastname;
            string userInpuYeatOfBirth;

            Console.WriteLine("what is your first name");
            FirstName = Console.ReadLine();

            Console.WriteLine("what is your last name");
            Lastname = Console.ReadLine();

            Console.WriteLine("when were you born");
            userInpuYeatOfBirth = Console.ReadLine();
            Int32 YearOfBirth;
             YearOfBirth = Int32.Parse(userInpuYeatOfBirth);
            int YeatOfBirthFinal = 2020 - YearOfBirth;

            Console.WriteLine($"hello, {FirstName} {Lastname}. you are {YeatOfBirthFinal} years old.");









        }
    }
}
