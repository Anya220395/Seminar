/*Напишите программу, которая 
1.принимает на вход число и 
2.выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int SumNumbers(int num)
{
    int sum = default;
    int count = 0; // методом накопления записываем сумму чисел
    while (num > 0) //пока число>0 отсекаем % последнее число и записываем его в сумму
    {
        sum = sum + num % 10;
        num = num/10;
        count++;
    }
    return sum;
}

int sumDigit = SumNumbers(number);
Console.WriteLine(sumDigit);
