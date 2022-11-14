/*Напишите цикл, который 
1.принимает на вход два числа (A и B) и 
2.возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB>0)
{
int DegreeAB(int numA, int numB)
{
    int degree = numA;
    for (int i = 1; i < numB; i++)
    {
        degree = degree * numA;
    }
    return degree;
}
Console.WriteLine($"Результат возведения числа {numberA} в степень {numberB} = {DegreeAB(numberA, numberB)}");
}
else Console.WriteLine("Введите число больше 0!");
