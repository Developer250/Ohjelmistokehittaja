using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //Muutetaan milet kilometreiksi
        Console.WriteLine("Please enter miles:");
        double miles = Convert.ToDouble(Console.ReadLine());
        double kilometers = miles * 1.6;
        Console.WriteLine(kilometers + " Kilometers");
    }
}
