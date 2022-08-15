//Задача 4.YES or NO вот в чем вопрос
//Напишите программу, которая принимает на вход число и в зависимости от условий выводит текст «YES», либо «NO».
//Условия:
//•	если число нечётное, то вывести «YES»;
//•	если число чётное в диапазоне от 2 до 5 (включительно), то вывести «NO»;
//•	если число чётное в диапазоне от 6 до 20 (включительно), то вывести «YES»;
//•	если число чётное и больше 20, то вывести «NO».
//Формат входных данных. На вход программе подаётся натуральное число.

using System;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число (num > 0): ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                if ((num % 2 != 0) | (num >= 6 && num <= 20)) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
            else Console.WriteLine("Некорретный ввод");
        }
    }
}
