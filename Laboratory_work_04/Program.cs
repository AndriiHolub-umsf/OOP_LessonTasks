using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_04
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        struct Employee // Структура Employee
        {
            public string Name; // Призвище співробітника
            public string Position; // Посада
            public int Year; // Рік прийняття на роботу
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Список співробітників
            List<Employee> employees = new List<Employee>();

            // Введення кількості співробітників
            Console.WriteLine("Введіть кількість співробітників:");
            int count = Convert.ToInt32(Console.ReadLine());

            // Перевірка на те, що кількість співробітників більше 0
            while (count <= 0)
            {
                Console.WriteLine("Кількість співробітників повинна бути більше нуля!");
                Console.WriteLine("Введіть кількість співробітників:");
                count = Convert.ToInt32(Console.ReadLine());
            }

            // Введення даних про співробітників
            Console.WriteLine("Введіть дані про співробітників:");

            for (int i = 0; i < count; i++) // Вводимо вказане кількість співробітників
            {
                Employee emp = new Employee();
                Console.Write("Призвище: ");
                emp.Name = Console.ReadLine();
                Console.Write("Посада: ");
                emp.Position = Console.ReadLine();
                Console.Write("Рік: ");
                emp.Year = Convert.ToInt32(Console.ReadLine());
                employees.Add(emp);
            }

            // Вивід списку співробітників
            PrintEmployees(employees);

            // Завдання 2: Метод, який повертає кількість співробітників з заданою посадою
            Console.WriteLine("\nВведіть посаду для підрахунку кількості співробітників:");
            string positionToFind = Console.ReadLine();
            int positionCount = CountEmployeesByPosition(employees, positionToFind);
            Console.WriteLine($"Кількість співробітників з посадою '{positionToFind}': {positionCount}");

            // Завдання 3: Введення року та вивід списку співробітників, прийнятих у вказаний рік
            Console.WriteLine("\nВведіть рік для виводу співробітників, прийнятих у цей рік:");
            int yearToFind = Convert.ToInt32(Console.ReadLine());
            List<Employee> hiredInYear = GetEmployeesHiredInYear(employees, yearToFind);
            PrintEmployees(hiredInYear);

            Console.ReadKey();
        }

        // Метод для виводу списку співробітників
        static void PrintEmployees(List<Employee> employees)
        {
            if (employees.Count == 0) // Перевірка на пустий список
            {
                Console.WriteLine("Немає співробітників для відображення.");
                return;
            }

            Console.WriteLine("\nСписок співробітників:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Призвище: {emp.Name}, Посада: {emp.Position}, Рік: {emp.Year}");
            }
        }

        // Метод для підрахунку кількості співробітників за посадою
        static int CountEmployeesByPosition(List<Employee> employees, string position)
        {
            int count = 0;
            foreach (var emp in employees)
            {
                if (emp.Position.Equals(position, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            return count;
        }

        // Метод для отримання співробітників, прийнятих у вказаний рік
        static List<Employee> GetEmployeesHiredInYear(List<Employee> employees, int year)
        {
            List<Employee> result = new List<Employee>();
            foreach (var emp in employees)
            {
                if (emp.Year == year)
                {
                    result.Add(emp);
                }
            }
            return result;
        }
    }

}
