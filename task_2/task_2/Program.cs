// Задача 4:
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using System;

namespace task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье целое число: ");
            int numberThree = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(numberOne, Math.Max(numberTwo, numberThree));
            Console.Write($"Максимальным числом из {numberOne}, {numberTwo}, {numberThree} является {max}");
        }
    }
}