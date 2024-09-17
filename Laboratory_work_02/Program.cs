using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_01
{
    internal class Program
    {
        const int ExampleCnt = 8;
        const int PracticalTaskCnt = 3;
        public static void Example01()
        {
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 20));
                Console.Write("{0} ", chisla[i]);
            }
        }
        public static void Example02()
        {
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 20));
                Console.Write("{0} ", chisla[i]);
            }


            int mx = chisla[0]; int nmx = 0;
            for (int i = 1; i < chisla.Count; i++)
            {
                if (chisla[i] > mx) { mx = chisla[i]; nmx = i; }
            }
            Console.WriteLine("\n{0} {1}", mx, nmx);

        }
        public static void Example03()
        {
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 10));
                Console.Write("{0} ", chisla[i]);
            }

            Console.WriteLine();
            int x = Convert.ToInt32(Console.ReadLine());
            chisla.Remove(x);
            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }
        }
        public static void Example04()
        {
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 10));
                Console.Write("{0} ", chisla[i]);
            }

            Console.WriteLine();
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = chisla.Count - 1; i >= 0; i--)
            {
                if (chisla[i] == x) chisla.Remove(x);
            }

            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }
        }

        public static void Example05()
        {
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 10));
                Console.Write("{0} ", chisla[i]);
            }

            Console.WriteLine();
            int k = Convert.ToInt32(Console.ReadLine());
            chisla.RemoveAt(k);
            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }
        }

        public static void Example06()
        {
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 20));
                Console.Write("{0} ", chisla[i]);
            }

            Console.WriteLine();
            for (int i = chisla.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 0) chisla.RemoveAt(i);
            }

            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }
        }

        public static void Example07()
        {
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 10));
                Console.Write("{0} ", chisla[i]);
            }

            Console.Write("\nВведите индекс: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            chisla.Insert(k, x);
            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }
        }

        public static void Example08()
        {
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 10));
                Console.Write("{0} ", chisla[i]);
            }

            Console.Write("\nВведите число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = chisla.Count - 1; i >= 0; i--)
            {
                if (chisla[i] % 2 == 0) chisla.Insert(i, x);
            }

            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }
        }

        public static void LabTask01()
        {
            Random random = new Random();
            List<int> randIntList = new List<int>();
            int N = 10; //кількість елементів

            for (int i = 0; i < N; i++)
            {
                randIntList.Add(random.Next(-5, 6));
            }
            Console.WriteLine("Колекція до видалення чисел, кратних 3 або 5:");
            foreach (int num in randIntList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            randIntList.RemoveAll(x => x % 3 == 0 || x % 5 == 0);

            Console.WriteLine("Колекція після видалення чисел, кратних 3 або 5:");
            foreach (int num in randIntList)
            {
                Console.Write(num + " ");
            }
        }

        public static void LabTask02()
        {
            Random random = new Random();
            List<int> randIntList = new List<int>();
            int N = 10; //кількість елементів
            int X = 30; //значення X

            for (int i = 0; i < N; i++)
            {
                randIntList.Add(random.Next(5, 51));
            }

            Console.WriteLine("Колекція до вставки -1:");
            foreach (int num in randIntList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            for (int i = randIntList.Count - 1; i >= 0; i--)
            {
                if (randIntList[i] > X)
                {
                    randIntList.Insert(i, -1);
                    break;
                }
            }

            Console.WriteLine("Колекція після вставки -1:");
            foreach (int num in randIntList)
            {
                Console.Write(num + " ");
            }
        }

        public static void LabTask03()
        {
            Random random = new Random();
            List<int> randIntList1 = new List<int>();
            List<int> randIntList2 = new List<int>();
            List<int> multResultList = new List<int>();
            int N = 10; //кількість елементів

            for (int i = 0; i < N; i++)
            {
                randIntList1.Add(random.Next(1, 11));
                randIntList2.Add(random.Next(1, 11));
                multResultList.Add(randIntList1[i] * randIntList2[i]);
            }

            Console.WriteLine("Перша колекція:");
            foreach (int num in multResultList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Друга колекція:");
            foreach (int num in multResultList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Третя колекція, добуток елементів двох перших:");
            foreach (int num in multResultList)
            {
                Console.Write(num + " ");
            }
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int i = 1;i <= ExampleCnt;i++)
            {
                string ExampleName = "Example0" + i.ToString();


                MethodInfo theMethod = typeof(Program).GetMethod(ExampleName);
                if(theMethod != null ) 
                {
                    Console.WriteLine("Running example " + ExampleName);
                    Console.WriteLine("Result:");

                    theMethod.Invoke(null, null);

                    Console.WriteLine();

                    Console.WriteLine("Press Anykey");
                    Console.ReadKey();
                }

            }



            for (int i = 1; i <= PracticalTaskCnt; i++)
            {
                string ExampleName = "LabTask0" + i.ToString();


                MethodInfo theMethod = typeof(Program).GetMethod(ExampleName);
                if (theMethod != null)
                {
                    Console.WriteLine("Running practical task " + ExampleName);
                    Console.WriteLine("Result:");

                    theMethod.Invoke(null, null);

                    Console.WriteLine();

                    Console.WriteLine("Press Anykey");
                    Console.ReadKey();
                }

            }

            Console.WriteLine("Press Anykey to exit");
            Console.ReadKey();
        }
    }
}
