/*Напишите программу, которая позаданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).*/

Console.Write("Введите номер четверти: ");
string quater = Console.ReadLine();

string Quater(string quaterXY)
{
    if (quater == "1") return "x > 0 : y > 0";
    if (quater == "2") return "x < 0 : y > 0";
    if (quater == "3") return "x < 0 : y < 0";
    if (quater == "4") return "x > 0 : y < 0";
    return "Введен некорректный номер четверти";
}
string xy = Quater(quater);
Console.WriteLine(xy);