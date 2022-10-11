// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using static System.Console;
Clear();

WriteLine("Введите размеры двумерного массива, максимальное и минимальное значение через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
WriteLine();
int[,] userArray = Create2dArray(parameters);
Print2dArray(userArray);

WriteLine();
WriteLine($"Минимальная сумма элементов находится в {MinSumOfRowsElementsIn2dArray(userArray)} строке");


int MinSumOfRowsElementsIn2dArray(int[,] inputArray)
{
    int sum = 0;
    int newSum = 0;
    int minRow = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum += inputArray[i, j];
        }
        minRow = newSum <= sum ? minRow : i;
        newSum = i == 0 ? sum : Math.Min(newSum, sum);
        sum = 0;
    }

    return minRow + 1;
}

int[,] Create2dArray(int[] param)
{
    int[,] createdArray = new int[param[0], param[1]];
    Random rnd = new Random();
    for (int i = 0; i < createdArray.GetLength(0); i++)
    {
        for (int j = 0; j < createdArray.GetLength(1); j++)
        {
            createdArray[i, j] = rnd.Next(param[2], param[3] + 1);
        }
    }
    return createdArray;
}

void Print2dArray(int[,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            Write($"{printedArray[i, j]}\t");
        }
        WriteLine();
    }
}
