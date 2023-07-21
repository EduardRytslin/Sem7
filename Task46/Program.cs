// Задача 46: Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами.

// m = 3, n = 4.

//      0    1    2     3

// 0    1    4    8    19
// 1    5   -2   33    -2
// 2    77   3    8     1

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

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);