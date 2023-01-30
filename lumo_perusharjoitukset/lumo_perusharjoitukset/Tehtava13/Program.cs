internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna luku metreinä");
        double metri;
        metri = Convert.ToDouble(Console.ReadLine());
        double yard = metri * 1.0936;
        Console.WriteLine(yard + " Yardia");//Tulostetaan vastaus ja teksti
    }
}