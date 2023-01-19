using System;

class Program
{
    static void Main()
    {
        int num;
        Console.WriteLine("Ole hyvä ja anna luku"); //Pyydetään käyttäjää antamaan luku
        num = Convert.ToInt32(Console.ReadLine());//Tässä muutetaan luku

        for (int i = 0; i < 10; i++) //Loopin avulla teemme 10:een asti toimintoa
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i)); //Lopuksi tulostamme kertotaulun näkyville tuloskineen
        }
    }
}
