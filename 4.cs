using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int height = int.Parse(Console.ReadLine());

        int i = height;
        while (i > 0)
        {
            int j = 0;
            while (j < i)
            {
                Console.Write("*");
                j++;
            }
            Console.WriteLine();
            i--;
        }
    }
}