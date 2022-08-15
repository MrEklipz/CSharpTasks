//Задача 2.Самое большое число, кратное 7
//Найдите самое большее число на отрезке от a до b, кратное 7.
//Входные данные. Вводится два целых числа a и b (a ≤ b), каждое из которых по модулю не превышает 2∗10^4.
//Выходные данные. Найдите самое большее число на отрезке от a до b, кратное 7, или выведите "NO" - если таковых нет.
//Примечание: 0 кратен любому числу!

using System;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число A (abs(A) <= 20000): ");
            int numA = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(numA) > 20001)
            {
                Console.WriteLine("Введено слишком маленькое или большое число");
                return;
            }

            Console.Write("Введите число B (B >= A, abs(B) <= 20000): ");
            int numB = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(numB) > 20001)
            {
                Console.WriteLine("Введено слишком маленькое или большое число");
                return;
            }

            if (numB < numA)
            {
                Console.WriteLine("Число B должно быть больше или равно числа А");
                return;
            }

            for (int i = numB; i >= numA; i--)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
