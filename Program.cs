﻿//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine());
        PrintNumbers(N);
    }
