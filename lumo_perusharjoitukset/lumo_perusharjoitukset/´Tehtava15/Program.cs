internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna ensimmäinen luku:");  //Pyydetään käyttäjää antamaan ensimmäinen luku   
        double a = Convert.ToDouble(Console.ReadLine());//Lisätään a-muuttujaan muuntaja
        Console.WriteLine("Anna anna toinen luku:");//Pyydetään käyttäjää antamaan toinen luku 
        double b = Convert.ToDouble(Console.ReadLine());//Lisätään b-muuttujaan muuntaja
        
        double vastaus;
         vastaus = a - b;

        Console.WriteLine(" Vastaus on:" + vastaus);
    }
}