internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        int b;
        int c;
        int d;
        int e;
        Console.WriteLine("Syötä 5 numeroa : ");
        x = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        d = Convert.ToInt32(Console.ReadLine());
        e = Convert.ToInt32(Console.ReadLine());

        //Käyttäjä syttää viisi lukua joita verrataan if-else vertailulla ja tulostetaan suurin numero

        if (x > b)
        {
            Console.WriteLine("{0} Suurin numero on ", x);
        }

         else if (b > c)
        { 
            Console.WriteLine("{0} Suurin numero on ", b);
         }

          else if (c > d)
        {
            Console.WriteLine("{0} Suurin numero ", c);
        }
           else  if (d > e)
        { 
              Console.WriteLine("{0} Suurin numero ", d);
        }


        else
        {
            Console.WriteLine("{0} Suurin numero ", e);
        }
  
    }
}
