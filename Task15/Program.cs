﻿/*Напишите программу, которая 
1.принимает на вход цифру, обозначающую день недели, и 
2.проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;


if (day == 6 || day == 7)
{
    Console.WriteLine(" Выходной ");
}
else if (day < 1 || day > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else
{
    Console.WriteLine("День не является выходным");
}
