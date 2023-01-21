internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)//Alustetaan

            if (i % 3 == 0)//Tarkistetaan onko luku jaollinen luvulla 3.
                Console.WriteLine(i);//Tulostetaan luvulla 3 jaolliset luvut näytölle.
    }
}