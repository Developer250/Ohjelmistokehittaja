
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            int x = 24;
            if (age > x)

                Console.WriteLine("Your age is: " + age + " " + "näytät ikäistäsi nuoremmalta");
            else
                Console.WriteLine("Olet liian nuori");
        }
    }
}

