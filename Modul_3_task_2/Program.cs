using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 2
Напишите метод, который проверяет является ли число числом Фибоначчи. Число передаётся в качестве
параметра. Если число простое нужно вернуть из метода true, иначе false.*/

namespace Modul_3_task_2
{
    internal class Program
    {
        static bool NumberFibonachi(int number)
        {
            if (Math.Sqrt(5 * (number * number) - 4) % 1 == 0 || Math.Sqrt(5 * (number * number) + 4) % 1 == 0)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: "); // 10946
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{number} {NumberFibonachi(number)}");
        }
    }
}
