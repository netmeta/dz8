// Задача 4 *.Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив. Обратите внимание, что максимальный размер такого массива ограничен. 
// Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.


Console.Clear();
Print2DArray(GenerateRandom2DArray());

int[,] GenerateRandom2DArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(2, 4), random.Next(2, 4)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int number = random.Next(10, 100);
            while (CheckContains(number, array))
            {
                number = random.Next(10, 100);
            }
            array[i, j] = number;
        }
    }
    return array;
}

bool CheckContains(int number, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            {
                return true;
            }
        }
    }
    return false;
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