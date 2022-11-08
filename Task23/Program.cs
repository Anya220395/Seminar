/*Напишите программу, которая 
1.принимает на вход число (N) и 
2.выдаёт таблицу кубов чисел от 1 до N.

5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void Cube(int number)
{
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"{i,4} | {i * i * i,4}");
        }
    }
    else
    {
        Console.WriteLine("Введите значение больше 0");
    }
}
Cube(N);

/*int count = 1;
while (count <= N)
{
    int cube = count*count*count;
    count++;
    Console.Write($"{cube} ");
}*/
