/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

Console.Write("Введите количество строк массивов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массивов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int[,] array2 = new int[m, n];

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

int[,] CompositionArray(int[,] array, int[,] array2)
{
    int[,] Composition = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Composition[i, j] = array[i, j] * array2[i, j];
        }
    }
    return Composition;
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
PrintArray(CompositionArray(array, array2));


