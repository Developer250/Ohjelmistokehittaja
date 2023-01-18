using System;
namespace tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Määritetään kokonaisluvuksi
            int first, second, third;

            //Ohjeistetaan käyttäjää laittamaan numero
            Console.WriteLine("Enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            third = int.Parse(Console.ReadLine());

            //Vertaillaan ja tulostetaan
            if (first > second)
            {
                //4
                if (first > third)
                {
                    Console.WriteLine("largest number : " + first);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("largest number : " + second);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
        }
    }
}