using System;

namespace program;

class Program
{
    static void Main()
    {
        Console.WriteLine("Програма для підрахунку кількості користувачів.");
        Console.Write("Введіть ID користувачів через пробіл: ");
        int[] numbers = Console.ReadLine()!
            .Split(new[] { ' ' })
            .Select(int.Parse)
            .ToArray();
        Console.WriteLine($"\nЗагальна кількість користувачів: {numbers.Length}");
    }
}
