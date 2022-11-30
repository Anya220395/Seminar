/*1.Задайте массив вещественных чисел. 
2.Найдите разницу между максимальным и минимальным элементами массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length) Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

double DiffBetweenMaxMinElem(double[] array)
{
    double maxElem = array[0];
    double minElem = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElem) maxElem = array[i];
        else if (array[i]< minElem) minElem = array[i];
    }
    double difference = maxElem - minElem;
    double result = Math.Round(difference,1);
    return result;
}

double[] arr = CreateArrayRndDouble(5, 1, 6);
PrintArray(arr);
double res = DiffBetweenMaxMinElem(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет {res}");
