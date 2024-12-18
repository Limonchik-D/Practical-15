using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {/// <summary>
     /// Задача 4. Заполнить одномерный массив случайным образом от -5 до 5 целыми числами.
     /// Увеличить все элементы в два раза. Вывести новые значения массива с использованием цикла foreach.
     /// </summary>
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[4];

            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = rnd.Next(-5, 6);
            }  
            Console.WriteLine($"Искодный массив: {string.Join(", ", array)}");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }

            foreach (int num in array)
            {
                Console.WriteLine($"Результат: {num}");
            }
            Console.ReadKey();
        }
    }
}
