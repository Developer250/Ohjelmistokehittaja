internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna luku senttimetreinä");//Pyydetään käyttäjää antamaan luku senttimetreinä
        double cm;//Alustetaan
        cm = Convert.ToInt32(Console.ReadLine());//Tallennetaan cm-muuttujaan muunnin

        double tuuma = cm * 0.39370;//Tehdään itse lasku

        Console.WriteLine(tuuma + " Tuumaa");//Tulostetaan laskun vastaus ja teksi
    }
}