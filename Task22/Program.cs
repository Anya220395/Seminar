/*Напишите программу, которая
1.принимает на вход число (N) и 
2.выдаёт таблицу квадратов чисел от 1 до N.*/

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
if (num > 0)
{
for (int i = 1; i <= num; i++)
{
Console.WriteLine($"|{i,4} | {i * i,4}|");
}
}
else
{
Console.WriteLine("Введите значение больше 0");
}
}

SquareTable(n);