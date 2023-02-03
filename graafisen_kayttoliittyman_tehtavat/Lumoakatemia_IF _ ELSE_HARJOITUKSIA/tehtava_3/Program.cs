internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Anna luku");
        double vastaus;
        vastaus  = Convert.ToDouble(Console.ReadLine());
        //ALustetaan luku1 ja luku2 sekä vastaus
        if (vastaus <= 0 && vastaus != 0)//Tarkistetaan onko annettu luku pienempi kuin nolla ja samanaikaisesti ei ole nolla
        {
            Console.WriteLine("Luku on negatiivinen " + vastaus);
        }

       else if (vastaus >= 0 && vastaus != 0)//Tarkistetaan onko annettu luku suurempi kuin nolla ja samanaikaisesti ei ole nolla
        {
            Console.WriteLine("Luku on positiivinen " + vastaus);
       }
        else if (vastaus == 0)
        {
            Console.WriteLine("Luku on nolla");//Tarkistetaan onko annettu luku nolla
        }
    }
}