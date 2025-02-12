﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int ThirdDigit(int numb)
// {
//     numb = Math.Abs(numb);
//     while (numb > 999)
//     {
//         numb = numb / 10;
//     }
//     return numb % 10;
// }

// if (Math.Abs(number) < 100) Console.WriteLine("Третьей цифры нет");
// else Console.WriteLine("Третья цифра числа --> " + ThirdDigit(number));

int DigitInPos(int numb, int pos)
{
    numb = Math.Abs(numb);
    if (numb < Math.Pow(10, pos - 1)) return -1;
    while (numb >= Math.Pow(10, pos))
    {
        numb = numb / 10;
    }
    return numb % 10;
}

int position = 3;
int result = DigitInPos(number, position);
if (result == -1) Console.WriteLine($"В числе нет цифры под номером {position}");
else Console.WriteLine($"В данном числе {position} по счету цифра --> {result}");
