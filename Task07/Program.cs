using System;

namespace Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, не оканчивающеся нулем: ");
            string number = Console.ReadLine();

            if (Convert.ToInt32(number) % 10 == 0)
            {
                Console.WriteLine("Нужно вводить такое число чтоб на ноль не оканчивалось!");
                return;
            }

            IsPalindrome(number);
        }
        static void IsPalindrome(string number)
        {
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - i - 1])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
