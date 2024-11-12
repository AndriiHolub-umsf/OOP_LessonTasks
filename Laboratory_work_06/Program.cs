using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratory_work_06
{
    class Program
    {
        static int[] array = new int[10];
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Ініціалізація масиву випадковими числами в діапазоні від 0 до 25
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 26);
            }

            Console.WriteLine("Масив: " + string.Join(", ", array));

            // Створення та запуск потоку T0
            Thread t0 = new Thread(CalculateProductBelowAverage);
            t0.Start();

            // Створення та запуск потоку T1
            Thread t1 = new Thread(CalculateSumOfEvenElements);
            t1.Start();

            // Очікування завершення обох потоків
            t0.Join();
            t1.Join();

            Console.ReadKey();
        }

        static void CalculateProductBelowAverage()
        {
            int average = (int)Math.Ceiling(array.Average());
            int product = 1;
            bool found = false;

            foreach (int num in array)
            {
                if (num < average)
                {
                    product *= num;
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine($"Добуток чисел, менших за середнє значення ({average}): {product}");
            }
            else
            {
                Console.WriteLine("Не знайдено чисел, менших за середнє значення.");
            }
        }

        static void CalculateSumOfEvenElements()
        {

            int sum = 0;
            for (int i = 0;i < array.Length; i++) 
            {   
                if((i+1)%2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"Сума всіх парних елементів: {sum}");
        }
    }

}
