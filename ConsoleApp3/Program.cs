using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //int[] array = new int[6];
            //Random rnd = new Random();
            //int i;
            //for (i = 0; i <= 5; i++) 
            // {
            //    array[i] = rnd.Next(-10, 10);
            //    Console.WriteLine($"mas[{i}]={array[i]}");
            //}
            //int k = -1;
            //for(i = 0; i <= 5; i++)
            // {
            //    if(i > 0 && array[i] == array[0])
            //     {
            //        i = k;
            //        Console.WriteLine($"i={i}");
            //    }
            //}
            //if (k == -1) 
            // {
            //    Console.WriteLine("Чисел, равные первому элементу,не имеется ");
            // }


            //Задание 2
            //int[] array = new int[100];
            //string a = "", b = "", c = "";
            //for(int i = 0; i <= 15; i++)
            // {
            //    if(array[i] > 0)
            //     {
            //        Console.Write(array[i]);
            //        a = a + " " + array[i].ToString();
            //    }
            //    if(array[i] <= 100)
            //     {
            //        b = b + " " + array[i].ToString();
            //    }
            //    if(array[i] % 2 != 0)
            //     {
            //        c = c + " " + array[i].ToString();
            //    }
            //}
            //Console.WriteLine("Все неотрицательные элементы: " + a);
            //Console.WriteLine("Все элементы, не превышающие числа 100: " + b);
            //Console.WriteLine("Все четные элементы: " + c);

            //Задание 3
            //int[] array = new int[12] { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            //for (int i = 0; i <= 11; i++)
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //int k = 0;
            //for(int i = 0; i <= 11; i++)
            // {
            //    if(array[i] < 0) k++;
            //}
            //Console.WriteLine($"k={k}");

            //Задание 4
            //int[] myArray = { 2, 4, 10, 8, 1, 3, 9, 6 };
            //float summ = 0;
            //int k = 0;
            //for (int i = 0; i <= 4; i++)
            //{
            //    if(i % 2 != 0)
            //     {
            //        summ = summ + myArray[i];
            //        k++;
            //    }
            //}
            //float sr_arf = summ / k;
            //Console.WriteLine("Среднее арифметическое ={0}", sr_arf);

            //Задание 5 
            //int[] array = new int[5];
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.Write($"array[{i}]=");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i <= 4; i++)
            //{
            //    array[i] += array[0];
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"array[{i}]= {array[i]}");
            //}

            Console.ReadKey();

        }
    }
}
