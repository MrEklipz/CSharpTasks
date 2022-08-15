//Задача 1.Какой символ встречается раньше?
//Дана строка. Определите, какой символ в ней встречается раньше: 'x' или 'w'.Если таких символов нет, вывести "-1". 
//Входные данные. На вход подается одна строка.
//Выходные данные. Необходимо вывести букву 'x' или 'w', которая встречается в строке раньше. Если таких символов нет в строке, то вывести "-1".

using System;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindWhatGoesFirstxOrw("aaaaaa"); //-1
            FindWhatGoesFirstxOrw("widget"); //w
            FindWhatGoesFirstxOrw("xerox");  //x
            FindWhatGoesFirstxOrw("privet"); //-1
            FindWhatGoesFirstxOrw("awx"); //w
        }

        static void FindWhatGoesFirstxOrw(string text)
        {
            foreach (var item in text.ToCharArray())
            {
                if (item == 'x')
                {
                    Console.WriteLine("x");
                    return;
                }
                else if (item == 'w')
                {
                    Console.WriteLine("w");
                    return;
                } 
            }
            Console.WriteLine("-1");
        }
    }
}
