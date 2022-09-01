// Домашняя задача 52.
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

void NewArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void AvgColumn(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        double avg = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[j, i];
            avg = sum / matrix.GetLength(1);
        }
        Console.Write($"Среднее арифметическое элементов столбца {i + 1} = {Math.Round(avg, 1)}");
        Console.WriteLine();
    }
    return;
}

NewArray(matrix);
PrintArray(matrix);
AvgColumn(matrix);
