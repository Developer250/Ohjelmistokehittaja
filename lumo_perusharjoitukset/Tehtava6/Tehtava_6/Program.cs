internal class Program
{
    private static void Main(string[] args)
    {
        Console.WindowHeight("Ole hyvä ja anna celsius luku");
        double celsius;
        celsius = Convert.ToDouble(Console.ReadLine());
        double fareh = (celsius * 9) / 5 + 32;
        Console.WriteLine(fareh);
    }
}

