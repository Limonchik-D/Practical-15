using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_15
{/// <summary>
/// Задача 1. Массив предназначен для хранения значений ростов двенадцати человек.
/// С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.
/// Вывести значения элементов с использованием цикла for. Найти средний рост.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hieght = new int[12];
            

            Random rnd = new Random();

            for (int i = 0; i < hieght.Length; i++) 
            {
                hieght[i] = rnd.Next(163, 191);
            }

            foreach (int h in hieght)
            {
                Console.WriteLine($"Рост: {h}");
            }

            int sum = 0;
            for (int i = 0; i < hieght.Length; i++) 
            {
                sum += hieght[i];
            }
            double average = (double)sum / hieght.Length;
            Console.WriteLine($"Средний рост: {average:F2}");
            Console.ReadKey();
        }
    }
}
