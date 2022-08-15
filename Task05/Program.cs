//Задача 5.Алгоритм сортировки.
//Реализовать сортировку пузырьком для последовательности целых чисел. 
//Последовательность произвольной длины, но содержит не менее двух элементов. 
//В консоль надо вывести все значения через пробел, отсортированные в порядке возрастания.

using System;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые числа через запятую: ");
            string[] numbers = Console.ReadLine().Split(new char[] {','});
            int[] numbersArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersArray[i] = int.Parse(numbers[i]);
            }
            BubleSort(numbersArray);

            Console.WriteLine("Отсортированный массив: ");
            foreach (int item in numbersArray)
            {
                Console.Write($"{item} ");
            }
        }

        static void BubleSort(int[] numArray)
        {
            for (int i = 0; i < numArray.Length; i++)
                for (int j = 0; j < numArray.Length - i - 1; j++)
                {
                    if (numArray[j] > numArray[j + 1])
                    {
                        int temp = numArray[j];
                        numArray[j] = numArray[j + 1];
                        numArray[j + 1] = temp;
                    }
                }
        }
    }
}
