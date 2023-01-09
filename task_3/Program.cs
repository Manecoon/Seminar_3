// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату Х первой точки: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х второй точки: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
Console.Write(Math.Round(result, 3));