// Задача 3: Задайте две квадратные матрицы одинакового размера. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.Write("Введите размер квадратных матриц: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = GenerateRandom2DArray(size); 
int[,] matrix2 = GenerateRandom2DArray(size); 

Print2DArray(matrix1);
Print2DArray(matrix2);
Print2DArray(MatrixMultiplication(matrix1, matrix2));


int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return resultMatrix;
}

int[,] GenerateRandom2DArray(int size)
{
    Random random = new Random();
    int[,] array = new int[size, size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
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