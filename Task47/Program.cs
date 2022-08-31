// Домашняя задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write ("Введите количество строк массива, m = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите количество столбцов массива, n = ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetArray (int m,int n)
{
    double[,] matrix = new double[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round((10*new Random().NextDouble()),2);
        }
    }
    return matrix;    
}

void PrintArray(double[,] inputMatrix)
{
    for (int i=0; i<inputMatrix.GetLength(0);i++)
    {
        for(int j=0; j<inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

double[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);