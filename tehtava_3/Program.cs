﻿using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pyydetään käyttäjää antamaan numero
            Console.WriteLine("ole hyvä ja anna numero");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                //Tehdään vertailut joka tapaukselle
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}

