using System;

class Program
{
   // taulukoita ones, tens ja hundreds tallentamaan numeroiden sanalliset vastineet.
    static string[] yhdet = { "", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän" };
    static string[] kymmenet = { "", "kymmenen", "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };
    static string[] sadat = { "", "sata", "kaksisataa", "kolmisataa", "neljäsataa", "viisisataa", "kuusisataa", "seitsemänsataa", "kahdeksansataa", "yhdeksänsataa" };
   
    //NumberToWords-metodi käy läpi numeron eri osuudet (sataset, kymmenet, yksiköt) ja yhdistää ne sanoiksi.
    static string NumeroSanoiksi(int numero)
    {
        if (numero == 0)
            return "nolla";

        string sanat = "";

        if ((numero / 100) > 0)
        {
            sanat += sadat[numero / 100] + " ";
            numero %= 100;
        }

        if ((numero / 10) > 0)
        {
            sanat += kymmenet[numero / 10] + " ";
            numero %= 10;
        }

        if (numero > 0)
        {
            sanat += yhdet[numero] + " ";
        }

        return sanat;
    }
    //Main-metodi kutsuu NumeroSanoiksi-metodia esimerkkienumeroiden kanssa ja tulostaa ne konsolille.
    static void Main(string[] args)
    {
        Console.WriteLine(NumeroSanoiksi(0));
        Console.WriteLine(NumeroSanoiksi(12));
        Console.WriteLine(NumeroSanoiksi(98));
        Console.WriteLine(NumeroSanoiksi(273));
    }
}
