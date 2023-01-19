internal class Program
{
    private static void Main(string[] args)
    {
        //Käyttäjän syöte laitetaan (t-kijrain) joka on merkkijono ja pisteet int-muotoon
        int pisteet = int.Parse(s: Console.ReadLine());
        //Tehdään vertailut muuttujalle pisteet ja numeroille (kun jos syöte on 1-3 välillä)
        if (pisteet >= 1 && pisteet <= 3)
        {
            //Kerrotaan käyttäjän antama syöte (numero) 10:llä
            pisteet *= 10;
            Console.WriteLine("Pisteet kertotulla 10:llä: " + pisteet);
        }
        //Tehdään vertailut muuttujalle pisteet ja numeroille (kun jos syöte on 4-6 välillä)
        else if (pisteet >= 4 && pisteet <= 6)
        {
            //Kerrotaan käyttäjän antama syöte (numero) 100:llä
            pisteet *= 100;
            Console.WriteLine("Pisteet kertotulla 100:lla: " + pisteet);
        }
        //Tehdään vertailut muuttujalle pisteet ja numeroille (kun jos syöte on 7-9 välillä)
        //Kerrotaan käyttäjän antama syöte (numero) 1000:llä
        else if (pisteet >= 7 && pisteet <= 9)
        {
            pisteet *= 1000;
            Console.WriteLine("Pisteet kertotulla 1000:lla: " + pisteet);
        }
        // Virheilmoitus tulostuu, jos syöte ei ole 1-9 välillä
        else
        {
            Console.WriteLine("Virhe: Pisteiden määrän täytyy olla välillä 1-9");
        }
    }
}