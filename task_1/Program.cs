// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Веедите первое число: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите второе число: ");
int Y = Convert.ToInt32(Console.ReadLine());
if (X > 0 && Y > 0)
    Console.WriteLine(" Первая четверть");
else if (X < 0 && Y > 0)
    Console.WriteLine(" Вторая четверть");
else if (X < 0 && Y < 0)
    Console.WriteLine(" Третья четверть");
else if (X > 0 && Y < 0)
    Console.WriteLine(" Четвертая четверть");