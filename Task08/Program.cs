//Задача 8.Количество чисел
//По данным числам, определите количество чисел, оканчивающиеся на 0 .  
//Входные данные: Вводится натуральное число N (N <= 10^5), а затем N чисел, каждое из которых по модулю не превышает 2*10^6.
//Выходные данные: Вычислите количество чисел, которые оканчиваются на 0.

using System;

namespace Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число N (N <= 100 000): ");
            int numberN = Convert.ToInt32(Console.ReadLine());
            if (numberN <= 0)
            {
                Console.WriteLine("Необходимо ввести натуральное число");
                return;
            }

            int[] numbersArray = new int[numberN];
            for (int i = 0; i < numberN; i++)
            {
                Console.Write("Введите число: ");
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int numbersEndsWZero = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] % 10 == 0) numbersEndsWZero++;
            }
            Console.WriteLine("количество чисел, оканчивающиеся на 0:{0}", numbersEndsWZero);
        }
    }
}
