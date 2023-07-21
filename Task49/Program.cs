// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив             Новый массив будет выглядеть
// выглядел вот так:                       вот так:
// 1 4 7 2                                 1 4 49 2
// 5 9 2 3                                 5 9  2 3
// 8 4 2 4                                64 4  4 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

void ReplaceEvenIndexElemSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            if (i%2 == 0 && j%2 == 0)
            {
                matrix[i,j] *= matrix[i,j];
            }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
ReplaceEvenIndexElemSquare(array2d);
PrintMatrix(array2d);