using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pratical_work_01
{
    internal class Program
    {
        const int ExampleCnt = 4;
        const int PracticalTaskCnt = 4;
        public static void Example01()
        {
            string s = "Dfg+t5-r7y;asd*s34;rt";
            int t = s.IndexOf(";");
            int i, k = 0;
            for (i = 0; i <= t; i++)
            {
                if (char.IsLetter(s[i])) k++;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
        public static void Example02()
        {
            string s = "АУАУАПАУК";
            int i = 0;
            do
            {
                string ss = s.Substring(i, 2);
                if (ss == "АУ")
                {
                    s = s.Insert(i, "О"); i = i + 3;
                }
                else
                {
                    i++;
                };
            }
            while (i < s.Length - 1);
            Console.WriteLine(s);
            Console.ReadKey();

        }
        public static void Example03()
        {
            string s = "бiологiя алгебра iсторiя географiя геометрiя";
            string c = "i";
            string[] a;
            a = s.Split(' ');
            int i;
            for (i = 0; i < a.Length; i++)
            {
                int t = a[i].IndexOf(c);
                if (t != -1) Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
        public static void Example04()
        {
            string s1 = "бiологiя алгебра iсторiя географiя геометрiя";
            //получили массив слов
            string[] a;
            a = s1.Split(' ');
            //переставили элементы массива
            //в обратном порядке
            Array.Reverse(a);
            //объединили элементы массива в строку
            //разделитель пробел
            string s2 = string.Join(" ", a);
            Console.WriteLine(s2);
            Console.ReadKey();
        }

        public static void PracticalTask01()
        {
            string s = "Hello, how are you, my friend, today?";
            int lastCommaIndex = s.LastIndexOf(',');
            if (lastCommaIndex != -1)
            {
                Console.WriteLine("Number of chars before the last comma: " + lastCommaIndex);
            }
            else
            {
                Console.WriteLine("Comma not found in the string.");
            }
            Console.ReadKey();
        }

        public static void PracticalTask02()
        {
            string S1 = "This is a sample string for removing a sample substring.";
            string S2 = "sample";
            string result = S1.Replace(S2, "");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static void PracticalTask03()
        {
            string sentence = "This is a beautiful day for a walk and a pizza";
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                if (word.EndsWith("a"))
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadKey();
        }

        public static void PracticalTask04()
        {
            string sentence = "This is a test sentence for test code validation.";
            int t = 4; // Номер слова, которое нужно исключить (нумерация с 1)
            string[] words = sentence.Split(' ');

            if (t > 0 && t <= words.Length)
            {
                StringBuilder newSentence = new StringBuilder();

                for (int i = 0; i < words.Length; i++)
                {
                    if (sentence[i] != sentence[t - 1]) // t - 1, так как индексы массива начинаются с 0
                    {
                        newSentence.Append(words[i]);
                    }

                    if (i < words.Length - 1 && i != t - 2)
                    {
                        newSentence.Append(" ");
                    }
                }

                Console.WriteLine("New sentence: " + newSentence.ToString());
            }
            else
            {
                Console.WriteLine("The number t is out of range for the number of words in the sentence.");
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            for(int i = 1;i <= ExampleCnt;i++)
            {
                string ExampleName = "Example0" + i.ToString();


                MethodInfo theMethod = typeof(Program).GetMethod(ExampleName);
                if(theMethod != null ) 
                {
                    Console.WriteLine("Running example " + ExampleName);
                    Console.WriteLine("Result:");

                    theMethod.Invoke(null, null);

                    Console.WriteLine();
                }

            }


            for (int i = 1; i <= PracticalTaskCnt; i++)
            {
                string ExampleName = "PracticalTask0" + i.ToString();


                MethodInfo theMethod = typeof(Program).GetMethod(ExampleName);
                if (theMethod != null)
                {
                    Console.WriteLine("Running practical task " + ExampleName);
                    Console.WriteLine("Result:");

                    theMethod.Invoke(null, null);

                    Console.WriteLine();
                }

            }

            Console.ReadKey();
        }
    }
}
