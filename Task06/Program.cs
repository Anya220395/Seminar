﻿/*Напишите программу, которая на вход 
1.принимает число и 
2.выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 ==0)
{
    Console.WriteLine($"Число {number} - четное ");
}
else
{
    Console.WriteLine($"Число {number} - нечетное ");
}