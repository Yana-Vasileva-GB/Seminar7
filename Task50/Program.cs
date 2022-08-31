// Домашняя задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк массива, m = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива, n = ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты числа для поиска в Вашем массиве:");
Console.Write("Номер строки: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] arr, int pos1, int pos2)
{
    if ((pos1 > -1 && pos1 < arr.GetLength(0)) && (pos2 > -1 && pos2 < arr.GetLength(1)))
    {
        Console.Write($"В Вашем массиве по координатам ({pos1}; {pos2}) находится значение {arr[pos1, pos2]}.");
    }
    else
    {
        Console.Write($"В Вашем массиве значение по заданным координатам не найдено.");
    }
    Console.WriteLine();
}

int[,] Array = GetArray(rows, columns);
PrintArray(Array);
FindNumber(Array, pos1, pos2);