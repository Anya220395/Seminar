/*Напишите программу, которая 
1.принимает на вход координаты двух точек и 
2.находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


Console.Write("Введите х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите у1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Range(int X1, int Y1, int X2, int Y2, int Z1, int Z2)
{
    int rangeX = X2 - X1;
    int rangeY = Y2 - Y1;
    int rangeZ = Z2 - Z1;
    double range3D = Math.Sqrt(Math.Pow(rangeX, 2) + Math.Pow(rangeY, 2) + Math.Pow(rangeZ, 2));
    return range3D;
}
double result = Range(x1, y1, x2, y2, z1, z2);
Console.Write($"А ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");
