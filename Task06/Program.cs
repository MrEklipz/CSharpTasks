//Задача 6.Конь
//Требуется определить, бьет ли конь, стоящий на клетке с указанными координатами (номер строки и номер столбца), фигуру, стоящую на другой указанной клетке.
//Формат входных данных: Вводятся четыре числа: координаты коня и координаты другой фигуры. Все координаты — целые числа в интервале от 1 до 8.
//Формат выходных данных: Программа должна вывести "YES", если конь может побить фигуру за 1 ход, в противном случае вывести "NO".
    
using System;

namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите координату X для коня (1-8): ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y для коня (1-8): ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату X для атакуемой фигуры (1-8): ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y для атакуемой фигуры (1-8): ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            CanHorseMoveHere(x1,y1,x2,y2);

        }

        static void CanHorseMoveHere(int x1, int y1, int x2, int y2)
        {
            if (((x1 - x2 == 1) | (x1 - x2 == -1)) & ((y1 - y2 == 2) | (y1 - y2 == -2)))
            {
                Console.WriteLine("YES");
            }
            else if (((x1 - x2 == 2) | (x1 - x2 == -2)) & ((y1 - y2 == 1) | (y1 - y2 == -1)))
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
        }
    }
}
