// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.

//     m = 3, n = 4.
//     0 1 2 3
//     1 2 3 4
//     2 3 4 5

int[,] CreateMatrixSumInd(int rows, int columns)
{
    int[,] matrix = new int[rows, columns]; // 3 x 4

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix, string sep = ", ")
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2d = CreateMatrixSumInd(3, 4);
PrintMatrix(array2d);