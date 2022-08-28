// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки");
Console.Write("x -> ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y -> ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z -> ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("x -> ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y -> ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z -> ");
int z2 = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {Math.Round(S, 2)}");