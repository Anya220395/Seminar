/*Напишите программу, которая 
1.принимает на вход пятизначное число и 
2.проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10000;
int secondDigit = (number / 1000) % 10;
int fourthDigit = (number % 100) / 10;
int lastDigit = number % 10;

if (number >= 10000 && number <= 99999)
{
    if (firstDigit == lastDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine($"Число {number} является палиндромом ");
    }
    else Console.WriteLine($"Число {number} не является палиндромом ");
}
else Console.WriteLine("Вы ввели неверное число! ");