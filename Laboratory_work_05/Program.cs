using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_05
{
    class TLine2D<T> where T : IComparable
    {
        // Поля для зберігання коефіцієнтів канонічного рівняння прямої
        private T a, b, c;

        // Конструктор без параметрів
        public TLine2D()
        {
            a = default(T);
            b = default(T);
            c = default(T);
        }

        // Конструктор з параметрами
        public TLine2D(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Конструктор копіювання
        public TLine2D(TLine2D<T> other)
        {
            this.a = other.a;
            this.b = other.b;
            this.c = other.c;
        }

        // Методи введення/виведення даних
        public void Input()
        {
            Console.Write("Введіть коефіцієнт a: ");
            a = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.Write("Введіть коефіцієнт b: ");
            b = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.Write("Введіть коефіцієнт c: ");
            c = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        }

        public void Output()
        {
            Console.WriteLine($"Рівняння прямої: {a}x + {b}y + {c} = 0");
        }

        // Метод знаходження точки перетину з іншою прямою
        public bool FindIntersection(TLine2D<T> other, out double x, out double y)
        {
            double a1 = Convert.ToDouble(a);
            double b1 = Convert.ToDouble(b);
            double c1 = Convert.ToDouble(c);
            double a2 = Convert.ToDouble(other.a);
            double b2 = Convert.ToDouble(other.b);
            double c2 = Convert.ToDouble(other.c);

            double determinant = a1 * b2 - a2 * b1;

            if (determinant == 0)
            {
                // Прямі паралельні або співпадають
                x = y = 0;
                return false;
            }

            x = (b1 * c2 - b2 * c1) / determinant;
            y = (a2 * c1 - a1 * c2) / determinant;
            return true;
        }

        // Метод визначення належності точки прямій
        public bool IsPointOnLine(double x, double y)
        {
            double aVal = Convert.ToDouble(a);
            double bVal = Convert.ToDouble(b);
            double cVal = Convert.ToDouble(c);
            return (aVal * x + bVal * y + cVal) == 0;
        }

        // Перевантаження операторів + (додавання коефіцієнтів прямих)
        public static TLine2D<T> operator +(TLine2D<T> line1, TLine2D<T> line2)
        {
            dynamic a1 = line1.a;
            dynamic b1 = line1.b;
            dynamic c1 = line1.c;
            dynamic a2 = line2.a;
            dynamic b2 = line2.b;
            dynamic c2 = line2.c;

            return new TLine2D<T>(a1 + a2, b1 + b2, c1 + c2);
        }

        // Перевантаження операторів - (віднімання коефіцієнтів прямих)
        public static TLine2D<T> operator -(TLine2D<T> line1, TLine2D<T> line2)
        {
            dynamic a1 = line1.a;
            dynamic b1 = line1.b;
            dynamic c1 = line1.c;
            dynamic a2 = line2.a;
            dynamic b2 = line2.b;
            dynamic c2 = line2.c;

            return new TLine2D<T>(a1 - a2, b1 - b2, c1 - c2);
        }

        // Метод порівняння двох прямих за коефіцієнтом a
        public int CompareTo(TLine2D<T> other)
        {
            return a.CompareTo(other.a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Створення двох об'єктів TLine2D
            TLine2D<double> line1 = new TLine2D<double>(1.0, -2.0, 3.0);
            TLine2D<double> line2 = new TLine2D<double>(2.0, -1.0, 4.0);

            // Виведення рівнянь прямих
            Console.WriteLine("Пряма 1:");
            line1.Output();
            Console.WriteLine("Пряма 2:");
            line2.Output();

            // Порівняння прямих
            int comparison = line1.CompareTo(line2);
            if (comparison < 0)
            {
                Console.WriteLine("Пряма 1 має менший коефіцієнт a, ніж Пряма 2.");
            }
            else if (comparison > 0)
            {
                Console.WriteLine("Пряма 1 має більший коефіцієнт a, ніж Пряма 2.");
            }
            else
            {
                Console.WriteLine("Прямі 1 і 2 мають однаковий коефіцієнт a.");
            }

            // Знаходження точки перетину
            if (line1.FindIntersection(line2, out double x, out double y))
            {
                Console.WriteLine($"Точка перетину: ({x}, {y})");
            }
            else
            {
                Console.WriteLine("Прямі паралельні або співпадають.");
            }

            // Перевантаження операторів + і -
            TLine2D<double> lineSum = line1 + line2;
            Console.WriteLine("Сума прямих:");
            lineSum.Output();

            TLine2D<double> lineDiff = line1 - line2;
            Console.WriteLine("Різниця прямих:");
            lineDiff.Output();

            Console.ReadKey();
        }
    }



}
