using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę dziesiętną do konwersji na binarną: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binaryNumber = Convert.ToString(decimalNumber, 2);
        Console.WriteLine("Liczba binarna: " + binaryNumber);

        Console.Write("Podaj liczbę binarną do konwersji na dziesiętną: ");
        string binaryInput = Console.ReadLine();
        int decimalResult = Convert.ToInt32(binaryInput, 2);
        Console.WriteLine("Liczba dziesiętna: " + decimalResult);
    }
}