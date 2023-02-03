internal class Program
{
    private static void Main(string[] args)
    {
        double luku1 = 100; double luku2 = 54.7; double luku3 = 10;
        if(luku1 > luku2 && luku1 > luku3)
        {
            Console.WriteLine(" Suurin luku on:" + luku1);
        }
        else if (luku2 > luku3 && luku2 > luku1)
        {
            Console.WriteLine(" Suurin luku on:" + luku2);
        }
        else
        {
            Console.WriteLine(" Suurin luku on:" + luku3);
        }
    }
}