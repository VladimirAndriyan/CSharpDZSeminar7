// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


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
Console.Write("Введите число строк m "); 
int m = Convert.ToInt32(Console.ReadLine());//число строк
Console.Write("Введите число стобцов n ");
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] matrix = FillMatrix(m, n, 0, 10);
PrintMatrix(matrix);

void FindElement(int[] arr)
{
    int a = arr[0];
    int b = arr[1];
    if(a >= 0 && a < m && b >= 0 && b < n)
    {
        Console.WriteLine($"Искомый элемент = {matrix[a,b]}");
    }
    else Console.WriteLine("Такого числа в массиве нет");
}
Console.WriteLine("Введите позицию элемента через запятую:");
int[] array = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
FindElement(array);