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
            Console.WriteLine("Задание 4:");
            Console.WriteLine("Даны действительное число х, натуральное число q (0 <= х < 1, q >= 2).\n" +
                              "Получить пять цифр q-ичного представления числа х, т. е. получить последовательность целых неотрицательных а(-1) ..., а(-5) такую," + 
                              "что x = a(-1) * q^-1 + ... + a(-5) * q^-5 + r, (r < q^-5).\n");

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
