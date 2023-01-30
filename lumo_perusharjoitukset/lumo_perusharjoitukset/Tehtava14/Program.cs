internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna luku farenheitina:");//Pyydetään käyttäjää antamaan luku farenheitina
        double farenh;//Alustetaan
        farenh = Convert.ToDouble(Console.ReadLine());//Lisätään farenh-muuttujaan muuntaja
        double celsius = farenh - 32 / 1.8000;//Tehdään lasku
        Console.WriteLine(celsius + " Celsiusta");//Tulostetaan celsius aste ja teksti
    }
}