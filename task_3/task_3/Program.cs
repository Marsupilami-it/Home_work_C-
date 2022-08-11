// Задача 6:
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

using System;

namespace task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.Write($"Число {number} является чётным.");
            }
            else
            {
                Console.Write($"Число {number} является не чётным.");
            }
        }
    }
}