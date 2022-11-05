/*Напишите программу, которая 
1.на вход принимает два числа и
2.проверяет, является ли первое число квадратом второго.

a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет*/

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = number2*number2 == number1;
if (number2*number2 == number1)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2} ");
}
else
{
    Console.WriteLine($"Число {number1}  не является квадратом числа {number2} ");
}