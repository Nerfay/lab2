using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        /// <summary>
        /// Variant 1
        /// 3, 10, 29, 66, 127 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3:--------------------------------------------------------");
            Task_3();

            Console.WriteLine("Задание 10:-------------------------------------------------------");
            Task_10();

            Console.WriteLine("\nЗадание 29:-------------------------------------------------------");
            Task_29();

            Console.WriteLine("Задание 66:-------------------------------------------------------");
            Task_66();

            Console.WriteLine("Задание 127:------------------------------------------------------");
            Task_127();
            Console.ReadLine();
        }
        /// <summary>Заполнить массив из пятнадцати элементов случайным образом:
        ///а) вещественными значениями, лежащими в диапазоне от 0 до 1;
        ///б) вещественными значениями х(22 ≤ х< 23);
        ///в) вещественными значениями х(0 ≤ х< 10);
        /// г) вещественными значениями х(–50 ≤ х< 50);
        /// д) целыми значениями, лежащими в диапазоне от 0 до 10 включительно.
        /// </summary>
        private static void Task_3()
        {
            Console.WriteLine("Заполнить массив из пятнадцати элементов случайным образом: а) вещественными значениями, лежащими в диапазоне от 0 до 1;");
            double[] array1 = new double[15];
            Random Random = new Random();
            for (int x = 0; x < array1.Length; x++)
            {
                array1[x] = Random.NextDouble();
            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array1));
            Console.WriteLine("Заполнить массив из пятнадцати элементов случайным образом: б) вещественными значениями х (22 ≤ х < 23);");
            double[] array2 = new double[15];
            for (int x = 0; x < array2.Length; x++)
            {
                array2[x] = Random.NextDouble() + 22;
            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array2));
            Console.WriteLine("Заполнить массив из пятнадцати элементов случайным образом: в) вещественными значениями х (0 ≤ х < 10);");
            double[] array3 = new double[15];
            for (int x = 0; x < array3.Length; x++)
            {
                array3[x] = 10 * Random.NextDouble();
            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array3));
            Console.WriteLine("Заполнить массив из пятнадцати элементов случайным образом: г) вещественными значениями х (–50 ≤ х < 50);");
            double[] array4 = new double[50];
            for (int x = 0; x < array4.Length; x++)
            {
                array4[x] = Random.NextDouble() * 100 - 50;
            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array4));
            Console.WriteLine("Заполнить массив из пятнадцати элементов случайным образом: целыми значениями, лежащими в диапазоне от 0 до 10 включительно.");
            int[] array5 = new int[15];
            for (int x = 0; x < array5.Length; x++)
            {
                array5[x] = Random.Next(0, 11);
            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array5));
        }
        /// <summary>
        /// Task_10:
        /// Дано натуральное число n ≤ 999999. Заполнить массив его цифрами, 
        /// расположенными в обратном порядке (первый элемент равен последней цифре, второй — предпоследней и т. д.). 
        /// Элементы массива, являющиеся цифрами числа n, вывести на экран.
        /// </summary>
        private static void Task_10()
        {
            Random Random = new Random();
            int numRnd = Random.Next(1000000);
            int num = numRnd;
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }
            Console.WriteLine("Массив:" + numRnd);
            int[] arr = new int[count];
            Console.WriteLine("Вывод результата:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = numRnd % 10;
                numRnd = numRnd / 10;
                Console.Write(arr[i] + " ");
            }
        }
        /// <summary>
        /// Task_29:
        /// Дана последовательность вещественных чисел а1, а2, ..., an. Выяснить, является ли она возрастающей.
        /// </summary>
        private static void Task_29()
        {
            double[] array = new double[10];
            Random Random = new Random();
            for (int x = 0; x < array.Length; x++)
            {
                array[x] = Random.NextDouble() * 10;
            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array));
            bool ans = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    ans = false;
                    break;
                }
            }
            Console.WriteLine("Являеться ли последовательность возрастающей?" + "\nВідповідь:" + ans);
        }
        /// <summary>
        /// Task_66:
        ///Найти произведение всех элементов массива целых чисел, меньших 0.
        /// </summary>
        private static void Task_66()
        {
            int[] array = new int[10];
            int multi = 1;
            Random Random = new Random();
            for (int x = 0; x < array.Length; x++)
            {
                array[x] = Random.Next(-10, 10);

            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array));
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    multi *= array[i];
                }
            }
            Console.WriteLine(multi);

        }
        /// <summary>
        /// Task_127:
        ///В последовательности вещественных чисел а1, а2, ..., an есть только положительные и отрицательные элементы. 
        ///Вычислить произведение отрицательных элементов P1 и произведение положительных элементов Р2. 
        ///Сравнить модуль Р2 с модулем P1, указать, какое из произведений по модулю больше.
        /// </summary>
        private static void Task_127()
        {
            int[] array = new int[10];
            int multiP1 = 1;
            int multiP2 = 1;
            Random Random = new Random();
            for (int x = 0; x < array.Length; x++)
            {
                array[x] = Random.Next(-10, 10);

            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array));
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    multiP1 *= array[i];
                }
                if (array[i] > 0)
                {
                    multiP2 *= array[i];
                }
            }
            Console.WriteLine("Произведение отрицательных элементов P1:");
            Console.WriteLine(multiP1);
            Console.WriteLine("Произведение положительных элементов P2:");
            Console.WriteLine(multiP2);
            if (Math.Abs(multiP1) > multiP2)
            {
                Console.WriteLine("Произведение отрицательных чисел по модулю больше ,чем произведение положительных чисел по модулю. ");
            }
            else
            {
                Console.WriteLine("Произведение положительных чисел по модулю больше ,чем произведение отрицательных чисел по модулю. ");
            }
        }
    }
}
