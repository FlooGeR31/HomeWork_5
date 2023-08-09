using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{

    /*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3, 4, 1, 77, 65] => 77 - 1 = 76*/



    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }


        static void Task1()
        {
            
            int[] array = GetRandomArray(10, 100, 999);

            Console.WriteLine("Сгенерированный массив:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            int evenCount = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }

            Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
            Console.ReadKey();
        }

        /*Задайте массив заполненный случайными положительными трёхзначными числами.
         * Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

        static int[] GetRandomArray(int size, int minvalue, int maxvalue)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minvalue, maxvalue + 1);
            }
            return array;
        }

       /* Задайте одномерный массив, заполненный случайными числами.
            Найдите сумму элементов, стоящих на нечётных индексах.*/
        static void Task2() 
        {
            int[] array = GetRandomArray(10, 1, 100);

            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[ {array[i]} ] ");
            }
            Console.WriteLine();

            int  sum= 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах: {sum}");
            Console.ReadKey();
        }

        /*Задайте массив целых чисел.Найдите разницу между максимальным и минимальным элементов массива.*/
        static void Task3() 
        {
            
            int[] array = GetRandomArray(10, 1, 100);

            PrintArray(array);

            int difference = GetDifferenceBetweenMaxAndMin(array);

            Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Сгенерированный массив:");
            foreach (var item in array)
            {
                Console.Write($"[ {item} ] ");
            }
            Console.WriteLine();
        }

        static int GetDifferenceBetweenMaxAndMin(int[] array)
        {
            int max = array[0];
            int min = array[0];

            foreach (var item in array)
            {
                if (item > max) max = item;
                if (item < min) min = item;
            }
            Console.WriteLine($"Максимальный элемент массива: {max}");
            Console.WriteLine($"Минимальный элемент массива: {min}");
            return max - min;
        }
    }
}
