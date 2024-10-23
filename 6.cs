using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int secretNumber = rand.Next(1, 11);
        int guess, attempts = 0;

        do
        {
            Console.Write("Zgadnij liczbę (od 1 do 10): ");
            guess = int.Parse(Console.ReadLine());
            attempts++;
        } while (guess != secretNumber);

        Console.WriteLine("Gratulacje! Zgadłeś liczbę po " + attempts + " próbach.");
    }
}