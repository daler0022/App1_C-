﻿using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Урок 1
            /*string x = Console.ReadLine();
            string y = Console.ReadLine();
            bool resultConvert = int.TryParse(x, out int x2) && int.TryParse(y, out int y2);
            if (resultConvert)
            {
                var sum = x2 + y2;
                Console.WriteLine(sum);
                Console.WriteLine("Convert Ok");
            }
            else
            {
                Console.WriteLine("error convert");
            }

            Console.ReadLine();*/
            #endregion
            #region Урок 2
            /*int a = 6;
            int b = 8;
            b--;
            Console.WriteLine($" a равно {++a}, b равно {b}");

            bool re = a >= b;
            Console.WriteLine(re);

            string l1 = "c#";
            string l2 = "c++";
            if (l1 == l2)
            {
                Console.WriteLine("Один и тот же ЯП");
            }
            else
            {
                Console.WriteLine("C# это не C++");
            }

            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            else
            {
                Console.WriteLine($"Число {num2} больше числа {num1}");
            }

            decimal n1 = 1;
            decimal n2 = 1;
            if (n1 < 10 || n2 > 100)
            {
                Console.WriteLine("Return True");
            }
            else
            {
                Console.WriteLine("Return False");
            }

            double t = double.Parse(Console.ReadLine());

            if (t % 2 == 0)
            {
                Console.WriteLine("Чётное число");
            }
            else
            {
                Console.WriteLine("Нечётное число");
            }*/
            #endregion

            //Задача №1
            /*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int evenNumber = 0;
            int oddNumber = 0;

            foreach(int i in arr)
            {
                if (i % 2 == 0)
                {
                    evenNumber++;
                }
                else
                {
                    oddNumber++;
                }
            }
            Console.WriteLine(evenNumber);
            Console.WriteLine(oddNumber);*/

            //Задача №2
            /*int[] array = { 1, 3, 3, 8, 7, 6, 7, 8, 9, 10 };

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        Console.WriteLine($"Повторяется число под индексом {j}");
                }
            }*/

            //Задача №3
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int summ = 0;
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    summ += arr[i];
                }
            }

            Console.WriteLine(summ);

            Console.ReadLine();
        }
    }
}