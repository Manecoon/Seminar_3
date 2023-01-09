// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
for (int index = 0; index < num; index++)
{
    array[index] = (index + 1) * (index + 1);
    Console.Write($"{array[index]} ");
}