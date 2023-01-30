using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Ohjeistetaan käyttäjää laittamaan kolme numeroa
        Console.WriteLine("Anna ensimmäinen luku : ");
        double luku1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Anna toinen luku : ");
        double luku2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Anna kolmas luku : ");
        double luku3 = int.Parse(Console.ReadLine());

        //Vertaillaan  luku keskenään ja tulostetaan suurin luku
        if (luku1 > luku2)
        {
            
             if (luku1 > luku3)
             {
                Console.WriteLine("largest number : " + luku1);
             }

            else
            {
                Console.WriteLine("largest number : " + luku3);
            }
        }

        //Muutoin,jos luku2 on jostain syystä suurempi kuin kolmas annettu luku, tulostetaan luku2 annettu luku suurimmaksi
        else
        {
            if (luku2 > luku3)
            {
                Console.WriteLine("largest number : " + luku2);
            }
            //Muutoin,jos luku3 on jostain syystä suurempi kuin muut annetut luvut, tulostetaan luku3 annettu luku suurimmaksi
            else
            {
                Console.WriteLine("largest number : " + luku3);
            }
        }
    }
}
