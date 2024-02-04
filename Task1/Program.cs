// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        if (m <= n)
        {
            
            PrintNaturalNumbers(m, n);
        }
    }

    static void PrintNaturalNumbers(int current, int end)
    {
        if (current <= end)
        {
            Console.Write(current);
            
            if (current < end)
            {
                Console.Write(", ");
            }
            
            PrintNaturalNumbers(current + 1, end);
        }
    }
}
