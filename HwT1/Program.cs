﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT1
{
    //Evdokhin Denis

    //1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
    //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
    //В данной задаче под парой подразумевается два подряд идущих элемента массива.
    //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.



    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            Random rnd = new Random();
            int[] mas = new int[20];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-10000, 10000);
            }
            for (int i = 0; i < mas.Length-1; i++)
            {
                if ((mas[i] % 3 == 0) || (mas[i+1] % 3 == 0)) res++;
            }
            Console.WriteLine();
            Console.WriteLine(res);
        }
    }
}
