using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj ilość liczb: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0, i = 0, number;

        while (i < n)
        {
            Console.Write("Podaj liczbę: ");
            number = int.Parse(Console.ReadLine());
            sum += number;
            i++;
        }

        double average = (double)sum / n;
        Console.WriteLine("Średnia: " + average);
    }
}