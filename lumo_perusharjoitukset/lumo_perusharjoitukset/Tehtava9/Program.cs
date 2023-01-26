using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ole hyvä ja anna kilometri luku");
        double km;
        km = Convert.ToDouble(Console.ReadLine());
        double miles = km * 1.609;
        Console.WriteLine(miles);
    }
}