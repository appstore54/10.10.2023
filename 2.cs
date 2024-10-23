using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę temperatur do przeliczenia: ");
        int count = int.Parse(Console.ReadLine());

        int i = 0;
        while (i < count)
        {
            Console.Write("Podaj temperaturę w stopniach Celsjusza: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine(celsius + " stopni Celsjusza to " + fahrenheit + " stopni Fahrenheita.");
            i++;
        }
    }
}