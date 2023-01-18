internal class Program
{
    private static void Main(string[] args)
    {
        int x, b;
        int c, d;
        int e;
        Console.WriteLine("Syötä 5 numeroa : ");
        x = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        d = Convert.ToInt32(Console.ReadLine());
        e = Convert.ToInt32(Console.ReadLine());

        if (x > b && x > c && x > d && x > 3)
        {
            Console.WriteLine("{0} Suurin numero on ", x);
        }

        if (b > x && b > c && b > d && b > e)

            Console.WriteLine("{0} Suurin numero on ", b);
    }

            if (C > d&& C > e)
        {
            Console.WriteLine("{0} Suurin numero on ", c);
        }

        if (d > x && d > b && d > c && d > e)
            (
              Console.WriteLine("{0} Suurin numero on ", d);
        }


        else
        {
            Console.WriteLine("{0} Suurin numero on ", e);
        }
  
}
//Käyttäjä syttää kaksi lukua joita verrataan if-else vertailulla ja tulostetaan suurin numero
