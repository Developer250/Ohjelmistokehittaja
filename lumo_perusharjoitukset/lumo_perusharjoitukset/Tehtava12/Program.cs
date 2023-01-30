internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna yard-luku");//Pyydetään käyttäjää antamaan luku yardina
        double yard;//Alustetaan
        yard = Convert.ToInt32(Console.ReadLine());//Tallennetaan cm-muuttujaan muunnin
        double metri = yard / 1.0936;//Tehdään itse lasku
        Console.WriteLine(metri + " Metriä");//Tulostetaan vastaus ja teksti
    }
}