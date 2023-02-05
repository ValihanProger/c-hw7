// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите первое измерение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе измерение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в двумерном массиве: ");
int target = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
int temp1 = 0;
int temp2 = 10;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (target == temp2 + temp1)
        {
            Console.WriteLine($"{target} -> {array[i,j]}");
            break;
        }
        temp1 = temp1 + 1;
    }
    temp1 = 0;
    temp2 = temp2+10;
    Console.WriteLine();
}