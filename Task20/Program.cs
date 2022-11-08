/*Напишите программу, которая
1.принимает на вход координаты двух точек и
2.находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

Console.WriteLine("Введите координаты точки 1:");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2:");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Range (int X1, int Y1, int X2, int Y2)
{
    int rangeX = X2-X1;
    int rangeY = Y2-Y1;
    double rangeZ = Math.Sqrt(Math.Pow(rangeX, 2)+ Math.Pow(rangeY,2));
    return rangeZ;
}
double result = Range(x1,y1,x2,y2);
Console.Write($"А ({x1},{y1}); B ({x2},{y2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");
