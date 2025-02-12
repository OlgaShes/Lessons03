﻿// // Задача 64: 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1) System.Console.WriteLine("Число не является натуральным");
else
{
    Console.WriteLine($"Натуральные числа в промежутке от {number} до 1:");
    NaturalNumbers(number);
}


void NaturalNumbers(int num)
{
    if (num == 1) Console.Write($"{num}");
    else
    {
        Console.Write($"{num}, ");
        NaturalNumbers(num - 1);
    }
}


