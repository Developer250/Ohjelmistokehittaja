internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ole hyvö ja anna tuuma luku");
        double tuuma;
        tuuma = Convert.ToDouble(Console.ReadLine());
        double cm = tuuma * 2.540;
        Console.WriteLine(cm);
    }
}