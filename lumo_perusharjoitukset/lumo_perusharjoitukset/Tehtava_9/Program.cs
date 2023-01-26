internal class Program
{
    private static void Main(string[] args)
    {
        //Muutetaan mailit kilometreiksi.
        Console.WriteLine("Ole hyvä ja anna km luku");
        double km;
        km = Convert.ToDouble(Console.ReadLine());
        double miles = km * 1.609;
        Console.WriteLine(miles);
    }
}