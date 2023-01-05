// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int[,] sortedArray = Generate2DArray();
Console.WriteLine("Исходный массив: ");
Print2DArray(sortedArray);
SelectionSort(sortedArray);
Console.WriteLine("Отсортированный массив: ");
Print2DArray(sortedArray);

int[,] Generate2DArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(2, 11), random.Next(2, 11)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(2, 14);

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

int[,] SelectionSort(int[,] array)
{
    int[,] sortedArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = 0;
            for (int d = j + 1; d < array.GetLength(1); d++)
            {
                if (array[i, j] < array[i, d])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, d];
                    array[i, d] = temp;
                }
            }
        }
    }
    return sortedArray;
}