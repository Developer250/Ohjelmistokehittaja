using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose your input data type:\n 1 --> int\n 2 --> double\n 3 --> string\n ...and hit ENTER");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Please enter your INTEGER number: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("The result is: {0}", (a + 1));
                break;
            case 2:
                Console.WriteLine("Please enter your DOUBLE number: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("The result is: {0}", (b + 1));
                break;
            case 3:
                Console.WriteLine("Please enter your STRING: ");
                string c = Console.ReadLine();
                Console.WriteLine("The result is: {0}", c + "*");
                break;

            default:
                Console.WriteLine("Invalid!");
                break;
        }
    }
}