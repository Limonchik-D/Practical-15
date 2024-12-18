using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {/// <summary>
     /// Задача 5. В массиве хранятся сведения об оценках 25 учеников по химии. Определить количество неуспевающих по химии учеников.
     /// </summary>
        static void Main(string[] args)
        {
            int[] array = new int[25];

            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = rnd.Next(2,6);
            }
                Console.WriteLine($"Оценки учеников: {string.Join(", ", array)}");

            int count = 0;
            foreach (int t in array)
            {
                if (t < 3)
                count++;
            }

            Console.WriteLine($"Кол-во неуспевающикх учеников: {count}");

            Console.ReadLine();

        }
    }
}
