using System;

internal class Program
{
    private static void Main(string[] args)
    {
       //Tehdään integeri määritykset ja annetaan arvot niille sekä laskukaavat
        int a = 8;
        int b = 5;
        int c = a + b;
        int d = a - b;
        int e = a * b;
        double f = a / b;

        Console.WriteLine("Anna ensimmäinen luku"); //Käyttäjää pyydetään antamaan ensimmäinen luku
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Anna toinen luku");//Käyttäjää pyydetään antamaan toinen luku
        b = Convert.ToInt32(Console.ReadLine());
        
        //Tulostetaan c-f tulokset konsoliin
        Console.WriteLine("Lukujen tulos on " + c);
        Console.WriteLine("Lukujen tulos on " + d);
        Console.WriteLine("Lukujen tulos on " + e);
        Console.WriteLine("Lukujen tulos on " + f);
    }
}