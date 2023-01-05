// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] array = Generate2DArray();
Print2DArray(array);
Console.Write($"Строка с наименьшей суммой элементов - {RowsSmallestSum(array)}");

int[,] Generate2DArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(3, 10), random.Next(3, 10)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(2, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }

        Console.WriteLine("]");
    }
    Console.WriteLine();
}

int RowsSmallestSum(int[,] array)
{
    int minSum = 0;
    int minRow = 1;
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        if (sumRow < minSum)
        {
            minSum = sumRow;
            minRow = i + 1;
        }
    }
    return minRow;
}