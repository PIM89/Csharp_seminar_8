/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.WriteLine("Задайте параметры прямоугольного двумерного массива.");
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
while (m == n)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введены не корректные данные! Число строк равно числу столбцов!");
    Console.WriteLine("Задайте параметры прямоугольного двумерного массива!");
    Console.ResetColor();
    Console.Write("Введите количество строк: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    n = Convert.ToInt32(Console.ReadLine());
}

int[,] array = new int[m, n];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

}

void SearchStringMin(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sum[i] += array[i, j];
    }
    int min = sum[0];
    int minIndex = 0;
    for (int k = 0; k < sum.Length; k++)
    {
        if (min > sum[k])
        {
            minIndex = k;
            min = sum[k];
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minIndex + 1} строка");
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
SearchStringMin(array);