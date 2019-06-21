using System;

namespace Exercise_4
{
    class Program
    {
        static string ConvertNumber(double number, int numSystem)
        {
            string result = "0.";
            for (int i = 0; i < 5; i++)
            {
                number = (number - (int)number) * numSystem;
                result += (int)number;
            }

            return result;
        }
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите число x:");
            while (!double.TryParse(Console.ReadLine(), out x) || x >= 1 || x < 0)
                Console.WriteLine("Ошибка! Введите вещественное число, которое входит в диапазон [0;1).");

            int q;
            Console.WriteLine("Введите число q:");
            while (!int.TryParse(Console.ReadLine(), out q) || q < 2)
                Console.WriteLine("Ошибка! Введите целое число, которое больше либо равно 2.");

            string result = ConvertNumber(x, q);

            Console.WriteLine($"\nЧисло {x} в {q}-ичном представлении: {result}...");
            Console.WriteLine($"Получившаяся последовательность (пять цифр {q}-ичного представления числа {x}): ");
            for (int i = 0; i < 5; i++)
                Console.Write($"{result.Substring(2 + i, 1)} ");
            Console.ReadLine();
        }
    }
}
