
internal class Program
{
    
    public static string firstLast(string str)
    {
        string sana;//Tehdään muuttuja
        Console.WriteLine("Anna sana");//Pyydetään käyttäjältä sanan ja vaihtaa sen ensimmäisen ja viimeisen kirjaimen keskenään.
        sana = Console.ReadLine();//Käyttäjän syöttämä sana tallennetaan muuttujaan "sana".

        // Sitten sana-muuttujan arvo muutetaan vaihtamalla sen ensimmäinen ja viimeinen kirjain.
        return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) +
          str.Substring(0, 1) : str;

    }

    public static void Main(string[] args)
    {
        Console.WriteLine(firstLast("Jani"));//Lopuksi tulsotetaan sana, jossa kirjaimet "J" ja "i" vaihtavat paikkaa

        Console.ReadKey();
    }
}