using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {/// <summary>
     /// Задача 3. Заполнить одномерный массив с клавиатуры и вывести элементы массива на экран в обратном порядке.
     /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Заполните масссив: ");
            for (int i = 0; i < size; i++) 
            {
                Console.Write("Элемент: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(array);
            
            Console.WriteLine($"{string.Join(", ", array)}");

            Console.ReadKey();
        }

    }
}
