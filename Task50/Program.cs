// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("(Нумерация с 0)");
Console.Write("Введите номер строки: ");
int i0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int j0 = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
SearchEleMatrix (array2d, i0, j0);

int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 3 x 4
    
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

void SearchEleMatrix (int[,] matrix, int i, int j)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1)) 
        Console.WriteLine($"Массив[{i},{j}]  —>  {matrix[i,j]}");
    else Console.WriteLine($"Массив[{i},{j}]  —>  такого элемента в массиве нет");
}