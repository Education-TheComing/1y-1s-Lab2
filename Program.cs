using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Task1();
            Console.WriteLine("Задание 2");
            Task2();
            Console.WriteLine("Задание 3");
            Task3();
            Console.WriteLine("Задание 4");
            Task4();
            Console.WriteLine("Задание 5");
            Task5();
            Console.WriteLine("Задание 6");
            Task6();
            Console.WriteLine("Задание 7");
            Task7();
            Console.WriteLine("Задание 8");
            Task8();
        }

        static void Task1()
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] list = new int[n];

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write("Введите элемент " + (i + 1) + ": ");
                list[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Исходный массив: ");

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < list.Length / 2; i++)
            {
                int temp = list[i];
                list[i] = list[list.Length - 1 - i];
                list[list.Length - 1 - i] = temp;
            }

            Console.Write("Инвертированный массив: ");

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
        }

        static void Task2()
        {
            int m = 3;
            int n = 3;
            int[,] result = new int[m, n];

            int number = 1;

            for (int i = 0; i < m; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        result[i, j] = number;
                        number++;
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        result[i, j] = number;
                        number++;
                    }
                }
            }

            Console.WriteLine("Матрица:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        static void Task3()
        {
            int m = 3;
            int n = 3;

            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[,] result = new int[m, n];

            int k = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = list[k];
                    k++;
                }
            }

            Console.Write("Одномерный массив: ");

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Двумерный массив:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        static void Task4()
        {
            int m = 3;
            int n = 3;
            int[,] result = new int[m, n];

            Random rnd = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = rnd.Next(1, 100);
                }
            }

            Console.WriteLine("Матрица:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }

                Console.WriteLine();
            }

            int min = result[0, 0];
            int max = result[0, 0];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (result[i, j] < min)
                    {
                        min = result[i, j];
                    }

                    if (result[i, j] > max)
                    {
                        max = result[i, j];
                    }
                }
            }

            Console.WriteLine("MIN = " + min);
            Console.WriteLine("MAX = " + max);
        }

        static void Task5()
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (!result.ContainsKey(c))
                {
                    result.Add(c, 1);
                }
            }

            Console.WriteLine("Строка: " + text);
            Console.WriteLine("Количество разных символов: " + result.Count);
        }

        static void Task6()
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (result.TryGetValue(c, out int value))
                {
                    result[c] = value + 1;
                }
                else
                {
                    result[c] = 1;
                }
            }

            Console.WriteLine("Количество повторений:");

            foreach (KeyValuePair<char, int> pair in result)
            {
                Console.WriteLine(pair.Key + " = " + pair.Value);
            }
        }

        static void Task7()
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            Console.Write("Введите символ для удаления: ");
            char symbol = char.Parse(Console.ReadLine());

            string result = "";

            foreach (char c in text)
            {
                if (c != symbol)
                {
                    result += c;
                }
            }

            Console.WriteLine("Исходная строка: " + text);
            Console.WriteLine("Строка после удаления: " + result);
        }

        static void Task8()
        {
            int n = 3000;
            int[,] result = new int[n, n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = rnd.Next(1, 100);
                }
            }

            long sum1 = 0;
            long sum2 = 0;

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum1 += result[i, j];
                }
            }

            sw.Stop();

            Console.WriteLine("Проход по строкам: " + sw.ElapsedMilliseconds + " мс");

            sw.Reset();
            sw.Start();

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    sum2 += result[i, j];
                }
            }

            sw.Stop();

            Console.WriteLine("Проход по столбцам: " + sw.ElapsedMilliseconds + " мс");
            Console.WriteLine("Сумма при проходе по строкам: " + sum1);
            Console.WriteLine("Сумма при проходе по столбцам: " + sum2);
        }
    }
}