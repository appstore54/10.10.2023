using System;

class Program
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Podaj liczbę większą od 1: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 1);

        int i = 1;
        Console.WriteLine("Liczby nieparzyste od 1 do " + n + ":");
        while (i <= n)
        {
            Console.Write(i + " ");
            i += 2;
        }
        Console.WriteLine();  
    }
}