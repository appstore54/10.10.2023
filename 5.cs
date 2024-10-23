using System;

class Program
{
    static void Main()
    {
        int sum = 0, count = 0, number;

        Console.WriteLine("Wprowadź liczby (0 kończy wprowadzanie): ");
        number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            sum += number;
            count++;
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Suma: " + sum);
        Console.WriteLine("Ilość wprowadzonych liczb: " + count);
    }
}