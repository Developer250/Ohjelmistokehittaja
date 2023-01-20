using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Anna suurempi kokonaisluku: "); //Pyydetään käyttäjää antamaan suurempi kokonaisluku
        for (int i = 1; i <= 10; i++)//Tehdään 10 kertaa syötetty luku
        {
           
            int num = Convert.ToInt32(Console.ReadLine());//Muuttaa syötteen kokonaisluvuksi
            for (int j = 1; j <= num; j++)//Tehdään rivitys
            {
                Console.Write(num + " ");//Tulostetaan luku ja tehdään välit jokaisen luvun jälkeen
            }
            Console.WriteLine();
        }
    }
}
