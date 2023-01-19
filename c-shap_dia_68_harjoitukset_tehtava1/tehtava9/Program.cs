internal class Program
{

    private static void Main(string[] args)

    {
        //Määritetään a, b ja c
        int a = 5;
        int b = 2;
        int c = 5 % 2;
        Console.WriteLine("Anna ensimmäinen luku");//Käyttäjää pyydetään antamaan ensimmäinen luku
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Anna ensimmäinen luku");//Käyttäjää pyydetään antamaan toinen luku
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tulos on " + c);//Tulostetaan tulokset konsoliin
    }
}