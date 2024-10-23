using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n (n-ty element ciągu Fibonacciego): ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, i = 2;

        Console.Write(a + " " + b + " ");

        while (i < n)
        {
            int next = a + b;
            Console.Write(next + " ");
            a = b;
            b = next;
            i++;
        }
        Console.WriteLine(); // Nowa linia po zakończeniu ciągu
    }
}