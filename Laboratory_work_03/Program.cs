using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random random = new Random();
            int N = 20;
            int[] array = new int[N];

            // Заповнення масиву випадковими значеннями від -50 до 50
            for (int i = 0; i < N; i++)
            {
                array[i] = random.Next(-50, 50);
            }

            Console.WriteLine("Масив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            int maxNegative = int.MaxValue;
            int minPositive = int.MaxValue;

            // Пошук максимального від’ємного і мінімального додатнього елементів
            for (int i = 0; i < N; i++)
            {
                if (array[i] < 0 && array[i] < maxNegative)
                {
                    maxNegative = array[i];
                }
                if (array[i] > 0 && array[i] < minPositive)
                {
                    minPositive = array[i];
                }
            }

            Console.WriteLine("\nМаксимальний від’ємний елемент: " + maxNegative);
            Console.WriteLine("Мінімальний додатній елемент: " + minPositive);

            Console.ReadKey();
        }
    }


}
