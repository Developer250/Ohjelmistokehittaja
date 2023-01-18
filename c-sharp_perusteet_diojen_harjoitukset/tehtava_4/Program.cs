
using System;
class prog
{
    public static void Main()
    {
        int x, b;
        Console.WriteLine("Syötä kaksi numeroa : ");
        x = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
   
        if (x > b)
        {
            Console.WriteLine("{0} Suurin numero on ", x);
        }
        else
        {
            Console.WriteLine("{0} Suurin numero on ", b);
        }
        Console.ReadLine();
    }
}