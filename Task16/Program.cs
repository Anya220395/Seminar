/*Напишите программу, которая 
1.принимает на вход два числа и 
2.проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/

bool Square(int num1, int num2)
{
    if (num1 * num1 == num2) return true;
    return false;
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(number1, number2);
if (result)
{
    Console.Write($"Число {number2} является квадратом числа {number1}");
}
else
{
    Console.Write($"Число {number2}  не является квадратом числа {number1}");
}