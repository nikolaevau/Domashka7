// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);

Console.Write("Среднее арифметическое каждого столбца: ");

for (int columnsCount = 0; columnsCount < matrix.GetLength(1); columnsCount++)
{
    double sum = 0;
    for (int rowsCount = 0; rowsCount < matrix.GetLength(0); rowsCount++)
    {
        sum = sum + matrix[rowsCount, columnsCount];
    }
    
    double average = sum/matrix.GetLength(0);

    if (columnsCount > 0)
    {
        Console.Write("; ");
    }

    Console.Write($"{average:f2}");
}
Console.WriteLine(".");

