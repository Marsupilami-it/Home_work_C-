// Задача 2:
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using System;

namespace task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            if (numberOne > numberTwo)
            {
                Console.Write($"Число {numberOne} больше, чем {numberTwo}");
            }
            else if (numberOne == numberTwo)
            {
                Console.Write($"Число {numberOne} равно числу {numberTwo}");
            }
            else
            {
                Console.Write($"Число {numberTwo} больше, чем {numberOne}");
            }
        }
    }
}