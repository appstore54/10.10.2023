using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Podaj ile razy pomnożyć liczbę: ");
        int times = int.Parse(Console.ReadLine());

        int result = number, i = 1;

        while (i < times)
        {
            result *= number;
            i++;
        }

        Console.WriteLine("Wynik: " + result);
    }
}