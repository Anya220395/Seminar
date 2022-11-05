/*Напишите программу, которая 
1. выводит случайное трёхзначное число и 
2. удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98*/

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число  => {number}");

/*int lastDigit = number % 10;
int firstDigit = number / 100;
int foundDigit = firstDigit * 10 + lastDigit;

Console.WriteLine($"Новое число  => {foundDigit}");*/

int DeleteSecondDigit(int num)
{
    int lastDigit = num % 10;
    int firstDigit = num / 100;
    int foundDigit = firstDigit * 10 + lastDigit;
    return foundDigit;
}

int result = DeleteSecondDigit (number);
Console.WriteLine($"Новое число  => {result}");


