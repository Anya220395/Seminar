﻿/*Напишите программу, которая 
1.принимает на вход трёхзначное число и 
2.на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    Console.WriteLine($"Вторая цифра числа {number} = {(number / 10) % 10} ");
}
else
{
    Console.Write("Введите ТРЕХзначное число!");
}