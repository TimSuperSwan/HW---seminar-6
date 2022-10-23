using System;

namespace Семинар6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //__________________Домашнее задание к 6 семинару_____________________

        /*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
        
        /*
        Console.WriteLine("Сколько чисел Вы хотите ввести?");
        int Num = int.Parse(Console.ReadLine()!);
        
        int[] Array = new int[Num];
        for (int i = 0; i < Num; i++)
        {
            if (i==0)
            {
                Console.WriteLine("Введите первое число:");
            }
            else
            {
                Console.WriteLine("Еще число:");
            }
            Array[i]=int.Parse(Console.ReadLine()!);
        }
        
        int Counter ( int[] array){
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }
        Console.WriteLine($"Среди чисел: {String.Join(",", Array)} колличество положительных ={Counter(Array)}"); 
        */


        /*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
        заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
        
        /*
        Console.WriteLine("Введите значения k1, b1, k2, b2");
        int k1 = int.Parse(Console.ReadLine()!);
        int b1 = int.Parse(Console.ReadLine()!);
        int k2 = int.Parse(Console.ReadLine()!);
        int b2 = int.Parse(Console.ReadLine()!);


        void Intersection (double k1, double b1, double k2, double b2){
            
            double x = (b2-b1)/(k1-k2);
            double y = k1 * x + b1;
            Console.WriteLine($"Точка пересечния по координатам: ({x:f1}; {y:f1})");
        }
        
        Intersection(k1, b1, k2, b2);

        */


        /*Доп.Задача Найти произведение всех элементов массива целых чисел, 
        меньших заданного числа. Размерность массива –10. 
        Заполнение массива осуществить случайными числами от 50 до 100*/ 

        /*

        int[] Array = GetArray(10,50,100);
        Console.WriteLine("Введите число:");
        int Num = int.Parse(Console.ReadLine()!);

        void FindProductUnderNum (int[] array, int num){
            int result = 1;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < num)
                {
                    result = result * array[i];
                    count++;
                    //Console.WriteLine(result);
                }
            }
            if (count>1)
            {
                Console.WriteLine($"в массиве [{String.Join(",", array)}] произведение чисел меньше {num} = {result}");
            }
            else
            {
                Console.WriteLine($"в массиве [{String.Join(",", array)}] нет чисел меньше {num}");
            }
        
        }

        FindProductUnderNum(Array,Num);
        
        
        int[] GetArray(int size, int minValue, int maxValue){
        int[] res = new int[size];
        for (int i = 0; i < size; i++)
        {
            res[i] = new Random().Next(minValue, maxValue + 1);
        }
        return res;
        }

        */
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
    }
}
