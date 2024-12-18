using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {/// <summary>
     /// Задача 2. Заполнить массив из восьми элементов следующими значениями с использованием явной инициализации:
     /// первый элемент массива равен 37, второй — 0, третий — 50, четвертый — 46, пятый — 34, шестой — 46, седьмой — 0, 
     /// восьмой —13. Найти максимальный и минимальный элементы массива.
     /// </summary>
        static void Main(string[] args)
        {

            int[] array = { 37, 0, 50, 46, 34, 46, 0, 13 };

            int max = array.Max();
            int min = array.Min();
            Console.WriteLine($"Минимальное значенеи массива: {min}, махсимальное значение: {max}. ");
            Console.ReadKey();
        }
    }
}
