/*
 * C# Program to Perform Celsius to Fahrenheit Conversion
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            //celcius ja farenheit määritetään integeriksi
            int celsius, farenh;
            //Käyttäjää pyydetään antamaan celsius luku, jonka kone sitten muuttaa farenheitiksi, kun se tulostaa
            Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
            celsius = int.Parse(Console.ReadLine());
            farenh = (celsius * 9) / 5 + 32;
            Console.WriteLine("0Temperature in Fahrenheit is(°F) : " + farenh);
            Console.ReadLine();

        }
    }
}