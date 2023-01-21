using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ole hyvä ja anna lause:");//Pyydetään käyttäjää antamaan lause.
        
        string lause = Console.ReadLine();//Tallennetaan muuttujaan "lause" käyttöjän syöttämä lause.
        string[] sanat = lause.Split(new[] { " " }, StringSplitOptions.None);//Saadaan palautusarvon elementit, jossa taulukko on tyhjä

        string sana = "";//Luodaan muuttuja, johon lauseen voi tallentaa.
        int x = 0;//Alustetaan x-kirjain nollaksi.

        //Tarkistetaan joka sana läpi.
        foreach (string str in sanat)

            if (str.Length > x)
            {
                sana = str;
                x = str.Length;
            }

        Console.WriteLine(" Pisin sana on: " + sana);//Tulostetaan mikä on pisin sana lauseessa.
        Console.ReadKey();
    }
         
}
