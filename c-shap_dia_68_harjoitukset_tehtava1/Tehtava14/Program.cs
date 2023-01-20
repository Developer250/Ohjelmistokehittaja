internal class Program
{
    public static void Main(string[] args)
    {
        int luku;//Luodaan muuttuja.
        Console.WriteLine("Syötä kaksi lukua");//Pyydetään käyttäjää syöttämään kaksi lukua.
        luku = Convert.ToInt32(Console.ReadLine());//Tallennetaan Käyttäjän syöttämät luvut muuttujaan "luku".
        luku = Convert.ToInt32(Console.ReadLine());
       

        if (luku > 0 && 1 > 0)//Tehdään vertailut käyttäjän syöttämiin lukuihin ja tulostetaan onko ne positiivisia, negatiivisia vai toinen jompaa kumpaa
        {
            Console.WriteLine("Molemmat ovat positiivisia");
        }

        if (luku < 0 && luku < -1)
        {
            Console.WriteLine("Molemmat ovat negatiivisia!");
        }
       
        if (luku > 0 || luku < 0)
        {
            Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen");
        }
    }
}